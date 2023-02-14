using Microsoft.EntityFrameworkCore;
using Project.Repositories.Entities;
using Project.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Repositories
{
    public class PersonRepositoey
    {
        private readonly IContext _context;
        public PersonRepositoey(IContext context)
        {
            _context = context;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.Persons.ToListAsync();
        }
        public async Task<Person> GetByIdsync(string id)
        {
            return await _context.Persons.FindAsync(id);
        }
        public async Task<Person> AddAsync(Person person)
        {
            var addPerson = _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            return addPerson.Entity;
        }
        public async Task<Person> UpdateAsync(Person person)
        {
            Person p = await _context.Persons.FindAsync(person.Id);
            if (p != null)
            {
                p.FirstName = person.FirstName;
                p.LastName = person.LastName;
                p.DateOfBirth = person.DateOfBirth;
                p.Gender = person.Gender;
                p.HMO = person.HMO;
                await _context.SaveChangesAsync();
            }
            return p;
        }
        public async Task DeleteAsync(string id)
        {
            _context.Persons.Remove(await GetByIdsync(id));
            await _context.SaveChangesAsync();
        }

    }
}
