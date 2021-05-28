using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyKafka.Application.Contracts.DataAccess;
using MyKafka.DataAccess.Repositories;

namespace MyKafka.DataAccess
{
    public static class DataAccessRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<MyKafkaDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MyKafkaConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IAssociationRepository, AssociationRepository>();
            return services;
        }
    }
}