using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketSepetiMvc.Startup))]
namespace MarketSepetiMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
