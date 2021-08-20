using System.Threading.Tasks;
using YemekSepetiClone.Models.Dtos.Auth;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Business.Abstract
{
    public interface IAuthService
    {
        Task RegisterCustomer(RegisterCustomerDto customerDto);
        Task<Customer> LoginCustomer(string email, string password);

        Task RegisterShop(RegisterShopDto shopDto);
        Task<Shop> LoginShop(string email, string password);
    }
}