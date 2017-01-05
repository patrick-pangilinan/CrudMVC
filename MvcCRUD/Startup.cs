using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCRUD.Startup))]
namespace MvcCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
