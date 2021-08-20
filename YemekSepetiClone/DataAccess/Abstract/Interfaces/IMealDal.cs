using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.Abstract.Interfaces
{
    public interface IMealDal:IEntityRepository<Meal>
    {
        Task<List<Meal>> GetListByShopId(int id);
    }
}