using BlastoiseApp.Data.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace BlastoiseApp.Config
{
    public static class WebDependencies
    {
        public static void Init(IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            CultureConfig();
            ClientsConfig(services);
            AddServices(services);

        }


        


        private static void ClientsConfig(IServiceCollection services) => 


        private static void AddServices(IServiceCollection services)
        {
            //services.AddScoped<IService, Service>();
        }
    }
}
