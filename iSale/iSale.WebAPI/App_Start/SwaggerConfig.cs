using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using WebActivatorEx;
using iSale.WebAPI;
using Swashbuckle.Application;
using Swashbuckle.Swagger;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace iSale.WebAPI
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration 
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "iSale.WebAPI");
                        c.OperationFilter<AddParametersFilter>();
                    })
                .EnableSwaggerUi(c =>
                    {
                        
                    });
        }
    }

    public class AddParametersFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            var scopes = apiDescription.ActionDescriptor.GetFilterPipeline()
                .Select(filterInfo => filterInfo.Instance)
                .OfType<AuthorizeAttribute>()
                .SelectMany(attr => attr.Roles.Split(','))
                .Distinct();

            if (scopes.Any())
            {
                operation.parameters.Add(new Parameter() { description = "Authorization token", @in = "header", name = "Authorization", required = true, type = "string" });
            }
        }
    }
}