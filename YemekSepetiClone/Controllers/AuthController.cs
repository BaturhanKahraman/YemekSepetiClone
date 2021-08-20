using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.Models.Dtos;
using YemekSepetiClone.Models.Dtos.Auth;

namespace YemekSepetiClone.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> LoginShop(LoginDto loginDto)
        {
            var result =await _authService.LoginShop(loginDto.Email, loginDto.Password);
            if (result == null)
            {
                return BadRequest("Lütfen doğru email ve şifre girin.");
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> LoginCustomer(LoginDto loginDto)
        {
            var result = await _authService.LoginCustomer(loginDto.Email,loginDto.Password);
            if(result == null)
            {
                return BadRequest("Lütfen doğru email ve şifre girin.");
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> RegisterCustomer(RegisterCustomerDto dto)
        {
            try
            {
                await _authService.RegisterCustomer(dto);
                return Ok("Başarıyla kayıt olundu");
            }
            catch (Exception e)
            {
                return BadRequest("Kayıt olunamadı. " + e.Message);
            }
           
        }
        [HttpPost]
        public async Task<IActionResult> RegisterShop(RegisterShopDto dto)
        {
            try
            {
                await _authService.RegisterShop(dto);
                return Ok("Başarıyla kayıt olundu");
            }
            catch(Exception e)
            {
                return BadRequest("Kayıt olunamadı. " + e.Message);
            }

        }

    }
}
