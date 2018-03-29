using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppNHibernate.Web.Startup))]
namespace WebAppNHibernate.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
