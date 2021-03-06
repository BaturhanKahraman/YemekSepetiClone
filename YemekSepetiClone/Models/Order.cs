using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using YemekSepetiClone.Models.Enums;

namespace YemekSepetiClone.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public DateTime OrderedAt { get; set; } = DateTime.Now;
        public DeliveryMethod DeliveryMethod { get; set; } = DeliveryMethod.WithCourier;
    }
}
