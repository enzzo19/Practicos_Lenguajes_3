using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP7_EnviandoMails__Juarez_Velazquez_Enzo_Jesus.Startup))]
namespace TP7_EnviandoMails__Juarez_Velazquez_Enzo_Jesus
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
