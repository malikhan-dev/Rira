
namespace Infra.Caching.Redis.Tools
{
    public class LockOptions
    {
        public LockType Lock { get; set; }
        public TimeSpan LockExpiry { get; set; }
        public TimeSpan LockWait { get; set; }
        public TimeSpan LockRetry { get; set; }
    }

    public class LockType
    {
        public LockType(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }


}
