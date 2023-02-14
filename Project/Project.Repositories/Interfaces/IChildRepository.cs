using Project.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Interfaces
{
    public interface IChildRepository
    {
        Task<List<Child>> GetAllAsync();
        Task<Child> GetByIdsync(string id);
        Task<Child> AddAsync(Child child);
        Task<Child> UpdateAsync(Child child);
        Task DeleteAsync(string id);

    }
}
