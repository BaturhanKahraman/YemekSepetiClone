using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.Controllers;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfMealDal:EfEntityRepositoryBase<Meal>,IMealDal
    {
        private readonly YemekSepetiContext _context;
        public EfMealDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Meal>> GetListByShopId(int id)
        {
            var result = await _context.Meals.Include(x => x.Category).ThenInclude(x => x.Shop)
                .Where(x => x.Category.ShopId == id).ToListAsync();
            return result;
        }
    }
}