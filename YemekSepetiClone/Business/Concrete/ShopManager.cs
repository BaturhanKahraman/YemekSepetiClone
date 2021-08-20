using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Business.Concrete
{
    public class ShopManager:IShopService
    {
        private readonly IShopDal _shopDal;

        public ShopManager(IShopDal shopDal)
        {
            _shopDal = shopDal;
        }

        public async Task<Shop> GetShopById(int id)
        {
            return await _shopDal.Get(x => x.Id == id);
        }

        public async Task<Shop> GetShopByEmailPassword(string email, string password)
        {
            return await _shopDal.Get(x => x.Email == email&&x.Password==password);
        }

        public async Task AddShop(Shop shop)
        {
            await _shopDal.Add(shop);
        }
    }
}