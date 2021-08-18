using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.Business.Abstract
{
    public interface IMealService
    {
        Task Add(Meal meal);
        Task Update(Meal meal);
        Task<IList<Meal>> GetList();
        Task<Meal> GetById(int id);
        Task Delete(Meal meal);
    }
}