using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookService.Startup))]
namespace BookService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
