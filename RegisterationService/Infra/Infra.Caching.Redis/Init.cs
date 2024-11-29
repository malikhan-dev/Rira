using Infra.Caching.Redis.Tools;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Infra.Caching.Redis
{
    public static class Init
    {
        public static void InitializeCaching(this IServiceCollection serviceCollection, string constr = "localhost:6379")
        {
            serviceCollection.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(constr));
            serviceCollection.AddSingleton<DistributedLock>();
        }
    }
}
