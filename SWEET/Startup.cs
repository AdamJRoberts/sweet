using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SWEET.Startup))]
namespace SWEET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
