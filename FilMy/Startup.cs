using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilMy.Startup))]
namespace FilMy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
