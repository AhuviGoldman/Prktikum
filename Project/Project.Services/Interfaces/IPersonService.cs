using Project.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Interfaces
{
    public interface IPersonService
    {
        Task<List<PersonDTO>> GetAllAsync();
        Task<PersonDTO> GetByIdsync(string id);
        Task<PersonDTO> AddAsync(PersonDTO person);
        Task<PersonDTO> UpdateAsync(PersonDTO person);
        Task DeleteAsync(string id);

    }
}
