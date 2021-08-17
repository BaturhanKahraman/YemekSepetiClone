using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.EntityFrameworkCore.Abstract.Interfaces
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        Task<bool> IsTableEmpty();
        Task<List<Category>> GetListWithMeals(Expression<Func<Category, bool>> filter = null);
    }
}