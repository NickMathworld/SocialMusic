using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialMusic.Startup))]
namespace SocialMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
