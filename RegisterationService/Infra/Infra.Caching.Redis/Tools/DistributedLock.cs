using RedLockNet.SERedis;
using RedLockNet.SERedis.Configuration;
using StackExchange.Redis;
using System.Net;

namespace Infra.Caching.Redis.Tools
{
    public class DistributedLock
    {
        private readonly IConnectionMultiplexer connectionMultiplexer;
        public DistributedLock(IConnectionMultiplexer connectionMultiplexer)
        {
            this.connectionMultiplexer = connectionMultiplexer;
        }

        public dynamic Factory(LockOptions opt)
        {
            return Factory(opt.Lock.Name, opt.LockExpiry, opt.LockWait, opt.LockRetry);
        }
        public dynamic Factory(string resourceName,TimeSpan lockExpiry, TimeSpan lockWait, TimeSpan lockRetry)
        {

            var address = connectionMultiplexer.GetEndPoints().GetValue(0).ToString().Split("/")[1];

            var host = address.Split(":")[0];

            var port = int.Parse(address.Split(":")[1]);

            var endPoints = new List<RedLockEndPoint>
            {
                new DnsEndPoint(host, port),
            };

            var redlockFactory = RedLockFactory.Create(endPoints);

            return redlockFactory.CreateLockAsync(resource: resourceName, expiryTime: lockExpiry, waitTime: lockWait, retryTime: lockRetry);

        }
    }
}
