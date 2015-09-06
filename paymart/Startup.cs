using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paymart.Startup))]
namespace paymart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
