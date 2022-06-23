using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uso_de_Bootstrap_en_Web_Forms.Startup))]
namespace Uso_de_Bootstrap_en_Web_Forms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
