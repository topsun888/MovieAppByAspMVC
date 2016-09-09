using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMovieMVC.Startup))]
namespace MyMovieMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
