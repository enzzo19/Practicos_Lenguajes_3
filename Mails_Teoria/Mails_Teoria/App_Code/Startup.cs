using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mails_Teoria.Startup))]
namespace Mails_Teoria
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
