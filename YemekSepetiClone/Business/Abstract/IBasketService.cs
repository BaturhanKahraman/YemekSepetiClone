using System.Threading.Tasks;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Basket;

namespace YemekSepetiClone.Business.Abstract
{
    public interface IBasketService
    {
        Task AddItem(BasketItemAddDto addDto);
        Task RemoveOrDecreaseBasketItem(BasketItemDecreaseDto dto);
        Task Add(Basket basket);
    }
}