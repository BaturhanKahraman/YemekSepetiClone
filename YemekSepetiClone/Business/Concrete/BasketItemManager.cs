using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.Business.Concrete
{
    public class BasketItemManager:IBasketItemService
    {
        private readonly IBasketItemDal _dal;

        public BasketItemManager(IBasketItemDal dal)
        {
            _dal = dal;
        }

        public async Task AddAsync(BasketItem item) => await _dal.Add(item);
        public async Task UpdateAsync(BasketItem item) => await _dal.UpdateAsync(item);
        public async Task DeleteAsync(BasketItem item) => await _dal.DeleteAsync(item);
    }
}