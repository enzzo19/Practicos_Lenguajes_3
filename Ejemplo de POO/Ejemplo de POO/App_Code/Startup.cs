using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ejemplo_de_POO.Startup))]
namespace Ejemplo_de_POO
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
