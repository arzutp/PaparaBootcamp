using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using PaparaHomework.Redis.Models.Products;
using StackExchange.Redis;

namespace PaparaHomework.Redis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private readonly IDistributedCache _cache;

        public RedisController(IDistributedCache cache)
        {
            _cache = cache;
        }

        [HttpGet]
        public IActionResult GetValue(string key)
        {
            //_cache.SetString("name", "arzu");
            var value = _cache.GetString(key);
            

            return Ok(value);
        }

        [HttpPost]
        public IActionResult SetValue(string key, string value)
        {
            _cache.SetString(key, value);

            return Ok(value);
        }
    }
}
