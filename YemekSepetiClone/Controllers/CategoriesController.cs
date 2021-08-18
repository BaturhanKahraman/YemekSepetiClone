using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            await _service.Add(category);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            IList<Category> categories =await _service.GetList();
            return Ok(categories);
        }
        [HttpGet]
        public async Task<IActionResult> GetListWithMeals()
        {
            IList<Category> categories = await _service.GetListWithMeals();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            IList<Category> categories = await _service.GetListWithMeals();
            return Ok(categories);
        }
    }
}
