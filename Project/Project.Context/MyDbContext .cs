using Microsoft.EntityFrameworkCore;
using Project.Repositories.Entities;
using Project.Repositories.Interfaces;

namespace Project.Context
{
    public class MyDbContext : DbContext, IContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Child> Children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AhuviDbContext;Trusted_Connection=True");
        }
    }
}