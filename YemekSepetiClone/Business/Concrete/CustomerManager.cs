using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _customerDal.Get(x => x.Id == id);
        }

        public async Task<Customer> GetCustomerByEmailPassword(string email, string password)
        {
            return await _customerDal.Get(x => x.Email == email && x.Password == password);
        }

        public async Task AddCustomer(Customer customer)
        {
            await _customerDal.Add(customer);
        }
    }
}