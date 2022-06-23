using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Recuperatorio_Juarez_Velazquez_Enzo_Jesus.Startup))]
namespace Recuperatorio_Juarez_Velazquez_Enzo_Jesus
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
