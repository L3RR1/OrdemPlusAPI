using Microsoft.EntityFrameworkCore;
using OrdemPlus.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly OrdemPlusDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(OrdemPlusDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(object id)
        {
            T entity = await GetByIdAsync(id);
            _dbSet.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
