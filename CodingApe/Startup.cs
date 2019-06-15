using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodingApe.Startup))]
namespace CodingApe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
