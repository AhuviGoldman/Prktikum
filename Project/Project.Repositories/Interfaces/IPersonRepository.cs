using Project.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();
        Task<Person> GetByIdsync(string id);
        Task<Person> AddAsync(Person person);
        Task<Person> UpdateAsync(Person person);
        Task DeleteAsync(string id);

    }
}
