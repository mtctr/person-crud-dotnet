using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MDC.Desafio.Presentation.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleApiController : ControllerBase
    {
        // GET: api/people
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/people/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/people
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/people/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
