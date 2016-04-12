using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplikacjaSMT.Startup))]
namespace AplikacjaSMT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
