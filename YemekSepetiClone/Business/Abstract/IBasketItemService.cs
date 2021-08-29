using System.Threading.Tasks;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.Business.Abstract
{
    public interface IBasketItemService
    {
        Task UpdateAsync(BasketItem item);
        Task AddAsync(BasketItem item);
        Task DeleteAsync(BasketItem item);
    }
}