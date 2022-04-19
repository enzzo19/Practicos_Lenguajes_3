using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coloquio_Juarez_Velazquez_Enzo_Jesus.Startup))]
namespace Coloquio_Juarez_Velazquez_Enzo_Jesus
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
