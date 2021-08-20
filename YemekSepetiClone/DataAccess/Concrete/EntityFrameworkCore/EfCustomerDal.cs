using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer>,ICustomerDal
    {
        private readonly YemekSepetiContext _context;

        public EfCustomerDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }
    }
}