using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppNHibernateTest.Web.Startup))]
namespace WebAppNHibernateTest.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
