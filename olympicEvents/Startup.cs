using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(olympicEvents.Startup))]
namespace olympicEvents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
