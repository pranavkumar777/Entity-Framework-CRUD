using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF_CRUD.Startup))]
namespace EF_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
