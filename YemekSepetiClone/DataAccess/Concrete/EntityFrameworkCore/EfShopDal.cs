using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.Models.Dtos.Shop;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfShopDal : EfEntityRepositoryBase<Shop>, IShopDal
    {
        private readonly YemekSepetiContext _context;

        public EfShopDal(YemekSepetiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ShopDetailDto> GetDetailById(Expression<Func<Shop,bool>> filter)
        {
            return await _context.Shops
                .Where(filter)
                .Include(x => x.Categories)
                .ThenInclude(x => x.Meals)
                .Select(x => new ShopDetailDto()
                {
                    ShopId = x.Id,
                    ImagePath = x.ImagePath,
                    Categories = x.Categories,
                    Speed = x.Speed,
                    ServiceQuality = x.ServiceQuality,
                    TasteQuality = x.TasteQuality,
                    ShopName = x.Name
                })
                .FirstOrDefaultAsync();
        }
    }
}