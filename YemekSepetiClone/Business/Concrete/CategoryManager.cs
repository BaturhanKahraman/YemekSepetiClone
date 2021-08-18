using System.Collections.Generic;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _dal;
        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }

        public async Task<bool> IsTableEmpty()
        {
            return await _dal.IsTableEmpty();
        }

        public async Task Add(Category category)
        {
            if (category.Name.StartsWith("iç"))
            {
                return;
            }
            await _dal.Add(category);
        }

        public async Task<IList<Category>> GetList()
        {
            return await _dal.GetList();
        }

        public async Task<IList<Category>> GetListWithMeals()
        {
            return await _dal.GetListWithMeals();
        }
    }
}