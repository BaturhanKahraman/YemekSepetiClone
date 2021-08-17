using System.Collections.Generic;
using System.Threading.Tasks;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.Business.Abstract
{
    public interface ICategoryService
    {
        Task<bool> IsTableEmpty();
        Task Add(Category category);
        Task<IList<Category>> GetList();
        Task<IList<Category>> GetListWithMeals();
    }
}