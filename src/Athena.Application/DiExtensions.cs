using Microsoft.Extensions.DependencyInjection;

namespace Athena.Application;

public static class DiExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddApplication()
        {
            return services;
        }
    }
}
