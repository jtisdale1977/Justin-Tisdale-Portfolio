using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Justin_Tisdale_Portfolio.Startup))]
namespace Justin_Tisdale_Portfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
