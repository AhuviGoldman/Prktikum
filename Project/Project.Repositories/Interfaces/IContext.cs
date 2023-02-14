using Microsoft.EntityFrameworkCore;
using Project.Repositories.Entities;

namespace Project.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet<Person> Persons { get; set; }
        DbSet<Child> Children { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
