using Athena.Application;
using Athena.Domain;
using Athena.Domain.Persistence.Context;
using Athena.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Athena.IoC;

public static class DiExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddAthena()
        {
            services
            .AddApplication()
            .AddDomain()
            .AddInfra();

            return services;
        }
    }

    extension(IHost host)
    {
        public async Task<IHost> UseDevelopmentAthena()
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<IAthenaDbContext>();

                await dbContext.ApplyMigrations();
            }
            return host;
        }
    }
}
