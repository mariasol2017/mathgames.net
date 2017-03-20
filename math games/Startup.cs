using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(math_games.Startup))]
namespace math_games
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
