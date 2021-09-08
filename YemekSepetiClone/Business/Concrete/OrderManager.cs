using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Order;

namespace YemekSepetiClone.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _dal;

        public OrderManager(IOrderDal dal)
        {
            _dal = dal;
        }

        public async Task Add(OrderDto orderdto)
        {

            var orderDetails = new List<OrderDetail>();
            orderdto.BasketItems.ForEach(x =>
            {
                orderDetails.Add(new OrderDetail()
                {
                    ItemId = x.MealId,
                    ItemPrice = x.Price,
                    Quantity = x.Quantity
                });
            });
            Order order = new()
            {
                DeliveryMethod = orderdto.DeliveryMethod,
                Address = orderdto.Address,
                Note = orderdto.Note,
                OrderedAt = DateTime.Now,
                OrderDetails = orderDetails
            };
            await _dal.Add(order);
        }
    }
}