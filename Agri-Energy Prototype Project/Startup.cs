using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agri_Energy_Prototype_Project.Startup))]
namespace Agri_Energy_Prototype_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
