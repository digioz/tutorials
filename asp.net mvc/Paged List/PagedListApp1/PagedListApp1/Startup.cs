using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PagedListApp1.Startup))]
namespace PagedListApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
