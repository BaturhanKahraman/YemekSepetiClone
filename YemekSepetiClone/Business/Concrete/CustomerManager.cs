using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IBasketService _basketService;
        public CustomerManager(ICustomerDal customerDal, IBasketService basketService)
        {
            _customerDal = customerDal;
            _basketService = basketService;
        }
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _customerDal.GetAsync(x => x.Id == id);
        }

        public async Task<Customer> GetCustomerByEmailPassword(string email, string password)
        {
            return await _customerDal.GetAsync(x => x.Email == email && x.Password == password);
        }

        public async Task AddCustomer(Customer customer)
        {
            await _customerDal.Add(customer);
            await _basketService.Add(new Basket() {CustomerId = customer.Id});

        }
    }
}