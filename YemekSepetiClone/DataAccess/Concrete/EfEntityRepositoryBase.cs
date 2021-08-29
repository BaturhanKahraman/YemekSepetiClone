using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;

namespace YemekSepetiClone.DataAccess.Concrete
{
    public class EfEntityRepositoryBase<T>:IEntityRepository<T>
    where T : class, new()
    {
        private readonly DbContext _context;
        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(filter);
        }

        public async Task<IList<T>> GetList(Expression<Func<T, bool>> filter)
        {
            return filter == null
                ? await _context.Set<T>().ToListAsync()
                : await _context.Set<T>().Where(filter).ToListAsync();
        }
    }
}