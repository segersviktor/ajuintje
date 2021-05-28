using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MyKafka.Application.ServiceRegistration
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatRRequestValidators(Assembly.GetExecutingAssembly());


            return services;
        }
    }
}
