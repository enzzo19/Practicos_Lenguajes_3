using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP5_Enzo__Juarez.Startup))]
namespace TP5_Enzo__Juarez
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
