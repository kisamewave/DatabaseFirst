using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseFirst.Startup))]
namespace DatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
