using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeleRecharge.Startup))]
namespace TeleRecharge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
