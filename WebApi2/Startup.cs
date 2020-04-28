using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApi2.Startup))]

namespace WebApi2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
