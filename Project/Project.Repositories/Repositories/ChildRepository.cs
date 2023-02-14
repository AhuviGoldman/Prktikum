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
    public class ChildRepository
    {

        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }
        public async Task<Child> GetByIdsync(string id)
        {
            return await _context.Children.FindAsync(id);
        }
        public async Task<Child> AddAsync(Child child)
        {
            var addChild = _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return addChild.Entity;
        }
        public async Task<Child> UpdateAsync(Child child)
        {
            Child c = await _context.Children.FindAsync(child.Id);
            if (c != null)
            {
                c.FirstName = child.FirstName;
                c.DateOfBirth = child.DateOfBirth;
                await _context.SaveChangesAsync();
            }
            return c;
        }
        public async Task DeleteAsync(string id)
        {
            _context.Children.Remove(await GetByIdsync(id));
            await _context.SaveChangesAsync();
        }
    }
}
