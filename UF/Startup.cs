using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UF.Startup))]
namespace UF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
