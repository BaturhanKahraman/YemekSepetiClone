using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Meal;

namespace YemekSepetiClone.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private readonly IMealService _service;
        public MealsController(IMealService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var mealList= await _service.GetList();
            return Ok(mealList);
        }

        [HttpGet]
        public async Task<IActionResult> GetDetail(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetMealsByShop(int id)
        {
            var result = await _service.GetMealsByShopId(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MealAddDto meal)
        {
            await _service.Add(meal);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Update(Meal meal)
        {
            await _service.Update(meal);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Meal meal)
        {
            await _service.Delete(meal);
            return Ok();
        }
    }
}
