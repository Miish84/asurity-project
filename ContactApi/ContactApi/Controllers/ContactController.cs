using ContactApi.Domain;
using ContactApi.View;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactDomain _contactDomain;

        public ContactController(IContactDomain contactDomain) {
            _contactDomain = contactDomain;
        }
        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ContactController>/5
        [HttpGet("{uuid}")]
        public Contact Get(string uuid)
        {
            return "value";
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
