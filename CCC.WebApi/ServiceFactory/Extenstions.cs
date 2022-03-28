using CCC.Service.ServiceFactory;
using Microsoft.AspNetCore.Mvc;

namespace CCC.WebApi.ServiceFactory
{
    public static class Extenstions
    {
        public static void AddWebApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddServices(configuration);
            services.AddCors();
        }
    }
}
