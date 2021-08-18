using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfMealDal:EfEntityRepositoryBase<Meal>,IMealDal
    {
        private readonly YemekSepetiContext _context;
        public EfMealDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }
    }
}