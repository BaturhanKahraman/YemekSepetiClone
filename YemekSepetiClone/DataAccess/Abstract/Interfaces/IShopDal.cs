using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YemekSepetiClone.Models.Dtos.Shop;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.DataAccess.Abstract.Interfaces
{
    public interface IShopDal : IEntityRepository<Shop>
    {
        Task<ShopDetailDto> GetDetailById(Expression<Func<Shop, bool>> filter);
    }
}