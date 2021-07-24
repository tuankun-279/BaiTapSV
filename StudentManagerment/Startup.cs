using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentManagerment.Startup))]
namespace StudentManagerment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
