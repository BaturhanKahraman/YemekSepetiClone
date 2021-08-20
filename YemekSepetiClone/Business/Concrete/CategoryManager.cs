using System.Collections.Generic;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Category;

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

        public async Task Add(CategoryAddDto categoryDto)
        {
            Category category = new()
            {
                Name = categoryDto.Name,
                ShopId = categoryDto.ShopId
            };
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

        public async Task Update(Category category)
        {
            await _dal.Update(category);
        }
    }
}