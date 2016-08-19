using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Full_tutorial.Startup))]
namespace Full_tutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
