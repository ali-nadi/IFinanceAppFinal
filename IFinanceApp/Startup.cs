using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IFinanceApp.Startup))]
namespace IFinanceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
