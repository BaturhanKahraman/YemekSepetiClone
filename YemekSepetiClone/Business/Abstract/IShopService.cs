using System.Collections.Generic;
using System.Threading.Tasks;
using YemekSepetiClone.Models.Dtos.Shop;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Business.Abstract
{
    public interface IShopService
    {
        Task<Shop> GetShopById(int id);

        Task<Shop> GetShopByEmailPassword(string email, string password);

        Task AddShop(Shop shop);
        Task<IList<Shop>> GetList();
        Task<ShopDetailDto> GetShopDetailById(int id);
    }
}