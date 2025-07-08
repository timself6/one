using Microsoft.AspNetCore.Mvc;

namespace one.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FIOController : ControllerBase
    {
        // GET: api/<FIOController>
        [HttpGet("{project}.fio")]
        public IEnumerable<string> Get(string project)
        {
            return new string[] { project };
        }

        // GET api/<FIOController>/5
        [HttpGet("{project}/{id}")]
        public string Get(string project, string id)
        {
            return "value";
        }

        // POST api/<FIOController>
        [HttpPost("{project}")]
        public void Post(string project, [FromBody] string value)
        {
        }

        // PUT api/<FIOController>/5
        [HttpPut("{project}/{id}")]
        public void Put(string project, string id, [FromBody] string value)
        {
            HttpContext.Response.Headers.Add("hello", $"{value.Length}");
        }

        // DELETE api/<FIOController>/5
        [HttpDelete("{project}/{id}")]
        public void Delete(string project, string id)
        {
        }
    }
}
