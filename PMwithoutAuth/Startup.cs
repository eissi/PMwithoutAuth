using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMwithoutAuth.Startup))]
namespace PMwithoutAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
