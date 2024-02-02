using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PaparaHomework.Redis.Redis;
using StackExchange.Redis;

namespace PaparaHomework.Redis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisTestController : ControllerBase
    {
        private readonly IDatabase _redisDb;
        public RedisTestController(RedisStackExchangeCacheManager redisStackExchangeCacheManager)
        {
            _redisDb = redisStackExchangeCacheManager.GetDb();
        }



        [HttpGet]
        public IActionResult Get(string key)
        {
            var value = _redisDb.StringGet(key);
            var jsonValue = JsonConvert.SerializeObject(value);

            return Ok(jsonValue);
        }

        [HttpPost]
        public IActionResult RedisString(string key, string value)
        {
            _redisDb.StringSet(key, value);

            return Ok(value);
        }


        [HttpGet("List")]
        public IActionResult AddToList()
        {
            _redisDb.ListLeftPush("user", "aslı");
            _redisDb.ListLeftPush("user", "volkan");
            _redisDb.ListLeftPush("user", "burhan");
            var value = _redisDb.ListGetByIndex("user", 1);

            var jsonValue = JsonConvert.SerializeObject(value);

            return Ok(jsonValue);
        }


        //istediğim sıralamayı verebilirim
        [HttpGet("SortedSet")]
        public IActionResult AddToSortedList()
        {
            _redisDb.SortedSetAdd("Categories", "Elma", 1);
            _redisDb.SortedSetAdd("Categories", "Armut", -1);
            _redisDb.SortedSetAdd("Categories", "Lahana", 2);

            RedisValue[] values = _redisDb.SortedSetRangeByRank("Categories");
            var jsonValue = JsonConvert.SerializeObject(values);

            return Ok(jsonValue);
        }

        [HttpGet("Hash")]
        public IActionResult AddToHash()
        {
            _redisDb.HashSet("hayvanlar", "kedi", "4 ayaklı");
            _redisDb.HashSet("hayvanlar", "köpek", "4 ayaklı");
            _redisDb.HashSet("hayvanlar", "tavuk", "2 ayaklı");
            _redisDb.HashSet("hayvanlar", "inek", "4 ayaklı");

            string value = _redisDb.HashGet("hayvanlar", "inek");
            //serialize etmeye gerek kalmadı neden?
            //var jsonValue = JsonConvert.SerializeObject(value);

            return Ok(value);
        }

        [HttpGet("Set")]
        public IActionResult AddToSet()
        {
            _redisDb.SetAdd("Hayvan", "kedi");
            _redisDb.SetAdd("Hayvan", new RedisValue[] { "inek", "köpek", "tavuk" });
            RedisValue[] values = _redisDb.SetMembers("Hayvan");

            var jsonValue = JsonConvert.SerializeObject(values);

            return Ok(jsonValue);
        }
    }
}
