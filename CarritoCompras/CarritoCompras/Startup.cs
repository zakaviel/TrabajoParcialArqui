using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarritoCompras.Startup))]
namespace CarritoCompras
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
