using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.Models;

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
        [HttpPost]
        public async Task<IActionResult> Add(Meal meal)
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
