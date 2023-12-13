using AutoMapper;
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
        private readonly IMapper _mapper;

        public ContactController(IContactDomain contactDomain, IMapper mapper) {
            _contactDomain = contactDomain;
            _mapper = mapper;
        }
        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            IEnumerable<Domain.Models.Contact> contacts = _contactDomain.Get();
            return _mapper.Map<IEnumerable<Contact>>(contacts);

        }

        // GET api/<ContactController>/5
        //[HttpGet("{uuid}")]
        //public Contact Get(string uuid)
        //{
        //    return "value";
        //}

        //// POST api/<ContactController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ContactController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ContactController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
