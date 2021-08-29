using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.Dtos.Order;
using YemekSepetiClone.Models.Enums;

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
            Order order = new()
            {
                DeliveryMethod = orderdto.DeliveryMethod,
                Address = orderdto.Address,
                Note = orderdto.Note,
                OrderedAt = DateTime.Now,
                Basket = new Basket()
                {
                    BasketItems = orderdto.BasketItems,
                    TotalPrice = orderdto.TotalPrice,
                    CustomerId = orderdto.UserId
                }
            };
            await _dal.Add(order);
        }
    }
}