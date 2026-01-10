using Athena.Domain.Persistence.Context;
using Athena.Infrastructure.Persistence.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Athena.Infrastructure;

public static class DiExtensions
{
    public static void AddInfra(this IServiceCollection services)
    {
        services.AddDbContext<IAthenaDbContext, AthenaDbContext>();
    }
}
