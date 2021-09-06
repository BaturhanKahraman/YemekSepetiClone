using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.Models.Dtos.Basket;

namespace YemekSepetiClone.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpPost]
        public async Task<IActionResult> AddBasketItem(BasketItemAddDto addDto)
        {
            await _basketService.AddItem(addDto);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DecreaseQuantityBasketItem(BasketItemDecreaseDto dto)
        {
            await _basketService.RemoveOrDecreaseBasketItem(dto);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetBasket(int customerId)
        {
            var basket = await _basketService.GetBasketByCustomerId(customerId);
            return Ok(basket);
        }

    }
}
