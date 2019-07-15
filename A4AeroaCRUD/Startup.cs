using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A4AeroaCRUD.Startup))]
namespace A4AeroaCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
