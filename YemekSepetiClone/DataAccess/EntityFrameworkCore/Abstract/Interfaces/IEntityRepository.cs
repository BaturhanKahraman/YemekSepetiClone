using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace YemekSepetiClone.DataAccess.EntityFrameworkCore.Abstract.Interfaces
{
    public interface IEntityRepository<T>
    where T:class,new()
    {
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> Get(Expression<Func<T,bool>> filter);
        Task<IList<T>> GetList(Expression<Func<T,bool>> filter =null);
    }
}