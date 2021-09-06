using System.Linq;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Basket;

namespace YemekSepetiClone.Business.Concrete
{
    public class BasketManager:IBasketService
    {
        private readonly IBasketDal _dal;
        private readonly IBasketItemService _basketItemService;
        private readonly IMealService _mealService;
        public BasketManager(IBasketDal dal, IBasketItemService basketItemService, IMealService mealService)
        {
            _dal = dal;
            _basketItemService = basketItemService;
            _mealService = mealService;
        }

        public async Task AddItem(BasketItemAddDto addDto)
        {
            var basket = await _dal.GetBasketWithBasketItemsAsync(x => x.CustomerId == addDto.CustomerId);
            Meal meal = await _mealService.GetByIdAsync(addDto.MealId);
            if(basket == null)
            {
                return;
            }
            if (basket.BasketItems.Any(x => x.MealId == addDto.MealId))
            {
                basket.BasketItems.FirstOrDefault(x => x.MealId == addDto.MealId).Quantity+=addDto.Quantity;
            }
            else
            {
                var basketItemToAdd = new BasketItem()
                {
                    MealId = addDto.MealId,
                    Quantity = 1,
                };
                basketItemToAdd.Price = meal.Price;
                basket.BasketItems.Add(basketItemToAdd);
            }

            await _dal.UpdateAsync(basket);
        }

        public async Task RemoveOrDecreaseBasketItem(BasketItemDecreaseDto dto)
        {
            var basket = await _dal.GetBasketWithBasketItemsAsync(x => x.CustomerId == dto.CustomerId);
            if (basket != null)
            {
                var removedItem = basket.BasketItems.FirstOrDefault(x => x.MealId == dto.MealId);
                await _basketItemService.UpdateAsync(removedItem);
                if (removedItem.Quantity == 0)
                {
                    await _basketItemService.DeleteAsync(removedItem);
                }
            }
        }

        public async Task Add(Basket basket)
        {
            await _dal.Add(basket);
        }

        public async Task<Basket> GetBasketByCustomerId(int id)
        {
            var basket =await _dal.GetBasketWithBasketItemsAsync(x => x.CustomerId == id);
            return basket;
        }
    }
}