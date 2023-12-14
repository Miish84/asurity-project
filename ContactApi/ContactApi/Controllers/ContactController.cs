using AutoMapper;
using ContactApi.Domain;
using ContactApi.Dtos;
using ContactApi.Filters;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactApi.Controllers
{
    [TypeFilter<CustomExceptionFilter>]
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
        public AppMessage Get()
        {
            var contacts =_mapper.Map<IEnumerable<Contact>>(_contactDomain.Get());
            return new AppMessage(payload: contacts, customMessage: "Success!");
        }

        // GET api/<ContactController>/{uuid}
        [HttpGet("{uuid}")]
        public AppMessage Get(string uuid)
        {
            var contact = _mapper.Map<Contact>(_contactDomain.GetByUuid(uuid));
            return new AppMessage(payload: contact, customMessage: "Success!");
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{uuid}")]
        public AppMessage Delete(string uuid)
        {
            _contactDomain.Delete(uuid);
            return new AppMessage(customMessage: "Success!");
        }

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
    }
}
