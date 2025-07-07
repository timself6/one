using Microsoft.AspNetCore.Mvc;

namespace one.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FIOController : ControllerBase
    {
        // GET: api/<FIOController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FIOController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FIOController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FIOController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FIOController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
