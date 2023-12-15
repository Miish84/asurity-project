using AutoMapper;
using ContactApi.Data;
using ContactApi.Dtos;
using ContactApi.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public LookupController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        // GET: api/<LookupController>/states
        [HttpGet("states")]
        public AppMessage GetStates()
        {
            // Since these are just lookups I'm skipping the domain layer
            var states = unitOfWork.Lookups.GetStates();
            return new AppMessage(payload: mapper.Map<IEnumerable<State>>(states), customMessage: "States retrieved");
        }

        // GET: api/<LookupController>/contactfrequencies
        [HttpGet("contactfrequencies")]
        public AppMessage GetContactFrequencies()
        {
            var freqs = unitOfWork.Lookups.GetContactFrequencies();
            return new AppMessage(payload: mapper.Map<IEnumerable<ContactFrequency>>(freqs), customMessage: "Contact frequencies retrieved");
        }
    }
}
