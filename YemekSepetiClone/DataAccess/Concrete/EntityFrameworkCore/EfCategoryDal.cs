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
    public class EfCategoryDal : EfEntityRepositoryBase<Category>, ICategoryDal
    {
        private readonly YemekSepetiContext _context;

        public EfCategoryDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }
        public async Task<bool> IsTableEmpty()
        {
            return await _context.Categories.AnyAsync();
        }

        public async Task<List<Category>> GetListWithMeals(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null
                ? await _context.Categories.Include(x => x.Meals).ToListAsync()
                : await _context.Categories.Where(filter).Include(x => x.Meals).ToListAsync();

        }
    }
}