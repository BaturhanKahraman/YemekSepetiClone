using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;

namespace YemekSepetiClone.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customer;

        public CustomerController(ICustomerService customerService)
        {
            _customer = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _customer.GetCustomerById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("User bulunamadı.");
        }
    }
}
