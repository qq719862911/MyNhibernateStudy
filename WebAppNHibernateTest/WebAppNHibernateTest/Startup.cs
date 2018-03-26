using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppNHibernateTest.Startup))]
namespace WebAppNHibernateTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
