using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pspasp.Startup))]
namespace pspasp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
