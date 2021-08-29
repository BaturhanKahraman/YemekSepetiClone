using System.Threading.Tasks;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Order;

namespace YemekSepetiClone.Business.Abstract
{
    public interface IOrderService
    {
        Task Add(OrderDto orderdto);
    }
}