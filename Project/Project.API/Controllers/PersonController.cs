using Microsoft.AspNetCore.Mvc;
using Project.Common.DTOs;
using Project.Services.Interfaces;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<List<PersonDTO>> Get()
        {
            return await _personService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<PersonDTO> Get(string id)
        {
            return await _personService.GetByIdsync(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _personService.DeleteAsync(id);
        }

        [HttpPost]
        public async Task<PersonDTO> Post([FromBody] PersonDTO p)
        {
            PersonDTO personDTO = await _personService.AddAsync(
                new PersonDTO()
                {
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    DateOfBirth = p.DateOfBirth,
                    HMO = p.HMO,
                    Gender = p.Gender,
                    Children = p.Children
                });

            return personDTO;
        }

        [HttpPut]
        public async Task<PersonDTO> Update([FromBody] PersonDTO p)
        {
            return await _personService.UpdateAsync(new PersonDTO()
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                DateOfBirth = p.DateOfBirth,
                HMO = p.HMO,
                Gender = p.Gender,
                Children = p.Children
            });

        }
    }
}
