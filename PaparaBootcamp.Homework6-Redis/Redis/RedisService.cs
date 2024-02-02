using StackExchange.Redis;

namespace PaparaBootcamp.Homework6_Redis.Redis;

public class RedisService
{
    ConnectionMultiplexer connectionMultiplexer;
    public void Connect() => connectionMultiplexer = ConnectionMultiplexer.Connect("localhost:7299");
    public IDatabase GetDb(int db) => connectionMultiplexer.GetDatabase(db);
}
