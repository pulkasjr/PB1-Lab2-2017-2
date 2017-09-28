using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSistemaControleCinema.Startup))]
namespace WebAppSistemaControleCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
