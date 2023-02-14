using Project.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Interfaces
{
    public interface IChildService
    {
        Task<List<ChildDTO>> GetAllAsync();
        Task<ChildDTO> GetByIdsync(string id);
        Task<ChildDTO> AddAsync(ChildDTO child);
        Task<ChildDTO> UpdateAsync(ChildDTO child);
        Task DeleteAsync(string id);

    }
}
