using System.Data.Entity;
using iSale.Domain.Concrete;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iSale.WebUI.Startup))]
namespace iSale.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EFDbContext>());
        }
    }
}
