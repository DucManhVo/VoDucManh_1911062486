using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoDucManh.Startup))]
namespace VoDucManh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
