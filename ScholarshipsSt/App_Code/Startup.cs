using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScholarshipsSt.Startup))]
namespace ScholarshipsSt
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
