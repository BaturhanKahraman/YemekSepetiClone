using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YemekSepetiClone.DataAccess.EntityFrameworkCore.Abstract.Interfaces;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.NHibernate
{
    public class NHCategoryDal : ICategoryDal
    {
        public Task Add(Category entity)
        {
            throw new NotImplementedException();
            //ekleme kodu
        }

        public Task Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Category>> GetList(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetListWithMeals(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsTableEmpty()
        {
            throw new NotImplementedException();
        }

        public Task Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
