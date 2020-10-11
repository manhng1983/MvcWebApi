using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VS2017Ent.ASPNETWebApp.MvcWebApi.Startup))]
namespace VS2017Ent.ASPNETWebApp.MvcWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
