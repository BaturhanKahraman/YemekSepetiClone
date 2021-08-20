using System.Threading.Tasks;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Business.Abstract
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerById(int id);
        Task<Customer> GetCustomerByEmailPassword(string email, string password);

        Task AddCustomer(Customer customer);
    }
}