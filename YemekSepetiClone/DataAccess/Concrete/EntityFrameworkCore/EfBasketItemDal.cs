using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfBasketItemDal:EfEntityRepositoryBase<BasketItem>,IBasketItemDal
    {
        private readonly YemekSepetiContext _context;
        public EfBasketItemDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }


    }
}