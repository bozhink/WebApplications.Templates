using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication.WebForms.Template.IndividualAuth.Startup))]
namespace WebApplication.WebForms.Template.IndividualAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
