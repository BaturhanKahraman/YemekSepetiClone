using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfOrderDal:EfEntityRepositoryBase<Order>,IOrderDal
    {
        private readonly YemekSepetiContext _context;
        public EfOrderDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }
    }
}