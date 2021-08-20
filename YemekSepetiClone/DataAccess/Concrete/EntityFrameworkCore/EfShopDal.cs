using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfShopDal:EfEntityRepositoryBase<Shop>,IShopDal
    {
        private readonly YemekSepetiContext _context;

        public EfShopDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }
    }
}