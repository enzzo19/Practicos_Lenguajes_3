using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP6_Juarez_Enzo.Startup))]
namespace TP6_Juarez_Enzo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
