using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfBasketDal:EfEntityRepositoryBase<Basket>,IBasketDal
    {
        private readonly YemekSepetiContext _context;
        public EfBasketDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Basket> GetBasketWithBasketItemsAsync(Expression<Func<Basket,bool>> filter)
        {
            return await _context
                .Baskets
                .Include(x => x.BasketItems)
                .Select(x=> new Basket()
                {
                    BasketItems = x.BasketItems.Select(y =>new BasketItem()
                    {
                        Quantity = y.Quantity,Price = y.Price,MealId = y.MealId
                    }).ToList(),CustomerId = x.CustomerId,Id = x.Id
                })
                .FirstOrDefaultAsync(filter);
        }
    }
}