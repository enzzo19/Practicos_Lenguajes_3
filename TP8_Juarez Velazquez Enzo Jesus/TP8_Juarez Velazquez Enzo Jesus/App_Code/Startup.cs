using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP8_Juarez_Velazquez_Enzo_Jesus.Startup))]
namespace TP8_Juarez_Velazquez_Enzo_Jesus
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
