using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication.WebForms.Template.IndovidualAuth.Startup))]
namespace WebApplication.WebForms.Template.IndovidualAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
