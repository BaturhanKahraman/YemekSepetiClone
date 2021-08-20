using System.Collections.Generic;
using System.Threading.Tasks;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Category;

namespace YemekSepetiClone.Business.Abstract
{
    public interface ICategoryService
    {
        Task<bool> IsTableEmpty();
        Task Add(CategoryAddDto category);
        Task<IList<Category>> GetList();
        Task<IList<Category>> GetListWithMeals();
    }
}