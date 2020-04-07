using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ERP_POC.Startup))]
namespace ERP_POC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
