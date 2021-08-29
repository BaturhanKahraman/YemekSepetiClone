using System.Linq.Expressions;
using System.Threading.Tasks;
using System;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.Abstract.Interfaces
{
    public interface IBasketDal:IEntityRepository<Basket>
    {
        Task<Basket> GetBasketWithBasketItemsAsync(Expression<Func<Basket, bool>> filter);
    }
}