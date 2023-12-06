using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreenThumbFinal.Database
{
    internal class Repository<T> where T : class
    {
        private readonly GreenThumbDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(GreenThumbDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<T?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }


    }
}
