using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace YemekSepetiClone.DataAccess.Abstract.Interfaces
{
    public interface IEntityRepository<T>
    where T:class,new()
    {
        Task Add(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetAsync(Expression<Func<T,bool>> filter);
        Task<IList<T>> GetList(Expression<Func<T,bool>> filter =null);
    }
}