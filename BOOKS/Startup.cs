using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BOOKS.Startup))]
namespace BOOKS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
