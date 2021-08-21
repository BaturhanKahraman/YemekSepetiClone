using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.Models.Dtos.Auth;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly ICustomerService _customerService;
        private readonly IShopService _shopService;
        public AuthManager(IShopService shopService,ICustomerService customerService)
        {
            _shopService = shopService;
            _customerService = customerService;
        }

        public async Task RegisterCustomer(RegisterCustomerDto customerDto)
        {
            Customer customer = new()
            {
                Lastname = customerDto.Surname, FirstName = customerDto.Name, Address = customerDto.Address,
                Password = customerDto.Password, Email = customerDto.Email,Phone = customerDto.Phone
            };
            await _customerService.AddCustomer(customer);
        }

        public async Task<Customer> LoginCustomer(string email,string password)
        {
            return await _customerService.GetCustomerByEmailPassword(email,password);
        }

        public async Task RegisterShop(RegisterShopDto shopDto)
        {
            Shop shop = new()
            {
                Address = shopDto.Address, Email = shopDto.Email, Password = shopDto.Password, Phone = shopDto.Phone,
                MinPrice = shopDto.MinPrice, Name = shopDto.Name, ServiceQuality = shopDto.ServiceQuality,
                ServiceTime = shopDto.ServiceTime, Speed = shopDto.Speed, TasteQuality = shopDto.TasteQuality,ImagePath = shopDto.ImagePath
            };
            await _shopService.AddShop(shop);
        }

        public async Task<Shop> LoginShop(string email,string password)
        {
            return await _shopService.GetShopByEmailPassword(email,password);
        }
    }
}