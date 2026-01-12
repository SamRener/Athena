using Athena.Domain.Persistence.Context;
using Athena.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Athena.Infrastructure;

public static class DiExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddInfra()
        {
            services.AddDbContext<IAthenaDbContext, AthenaDbContext>();
            return services;
        }
    }

    extension(IAthenaDbContext context)
    {
        public async Task ApplyMigrations()
        {
            if (context is AthenaDbContext dbContext)
            {
                var migrations = await dbContext.Database.GetPendingMigrationsAsync();
                if (!migrations.Any())
                    return;
                
                await dbContext.Database.MigrateAsync();
            }
        }
    }
}
