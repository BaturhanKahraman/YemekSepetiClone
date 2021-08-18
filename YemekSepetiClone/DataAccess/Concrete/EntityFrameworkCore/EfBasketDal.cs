using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfBasketDal:EfEntityRepositoryBase<Basket>,IBasketDal
    {
        private readonly YemekSepetiContext _context;
        public EfBasketDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }
    }
}