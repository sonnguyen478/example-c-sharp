using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(practice_c_sharp.Startup))]
namespace practice_c_sharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
