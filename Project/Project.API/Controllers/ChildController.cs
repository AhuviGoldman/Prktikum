using Microsoft.AspNetCore.Mvc;
using Project.Common.DTOs;
using Project.Services.Interfaces;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService = childService;
        }

        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(string id)
        {
            return await _childService.GetByIdsync(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childService.DeleteAsync(id);
        }

        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildDTO c)
        {
            ChildDTO childDTO = await _childService.AddAsync(
                new ChildDTO()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    DateOfBirth = c.DateOfBirth,
                });

            return childDTO;
        }

        [HttpPut]
        public async Task<ChildDTO> Update([FromBody] ChildDTO c)
        {
            return await _childService.UpdateAsync(new ChildDTO()
            {
                Id = c.Id,
                FirstName = c.FirstName,
                DateOfBirth = c.DateOfBirth,
            });

        }
    }
}
