using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Voxus.Teste.Startup))]
namespace Voxus.Teste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
