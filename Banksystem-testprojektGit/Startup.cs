using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Banksystem_testprojektGit.Startup))]
namespace Banksystem_testprojektGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
