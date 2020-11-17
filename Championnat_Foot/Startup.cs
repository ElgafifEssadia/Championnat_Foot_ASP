using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Championnat_Foot.Startup))]
namespace Championnat_Foot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
