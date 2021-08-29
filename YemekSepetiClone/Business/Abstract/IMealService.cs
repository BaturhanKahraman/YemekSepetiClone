using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Meal;

namespace YemekSepetiClone.Business.Abstract
{
    public interface IMealService
    {
        Task Add(MealAddDto meal);
        Task Update(Meal meal);
        Task<IList<Meal>> GetList();
        Task<Meal> GetByIdAsync(int id);
        Task Delete(Meal meal);
        Task<List<Meal>> GetMealsByShopId(int id);
    }
}