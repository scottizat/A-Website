using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A_Website.Startup))]
namespace A_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
