using System.Web.Http;
using WebActivatorEx;
using iSale.WebAPI;
using Swashbuckle.Application;

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
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}