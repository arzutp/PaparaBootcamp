using StackExchange.Redis;

namespace PaparaHomework.Redis.Redis
{
    public class RedisStackExchangeCacheManager
    {
        private readonly ConnectionMultiplexer _redisConnector;
        public RedisStackExchangeCacheManager(IConfiguration configuration)
        {
            var redisServerUrl = configuration.GetConnectionString("Redis");
            _redisConnector = ConnectionMultiplexer.Connect(redisServerUrl);
        }
        public IDatabase GetDb(int dbIndex = -1)
        {
            return _redisConnector.GetDatabase(dbIndex);
        }
    }
}
