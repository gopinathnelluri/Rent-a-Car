using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRentalSystem.Startup))]
namespace CarRentalSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
