using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekSepetiClone.Models.Enums;

namespace YemekSepetiClone.Models.Dtos.Order
{
    public class OrderDto
    {
        public int UserId { get; set; }

        public List<BasketItem> BasketItems { get; set; }

        public decimal TotalPrice { get; set; }

        public string Note { get; set; }
        public string Address { get; set; }

        public DeliveryMethod DeliveryMethod { get; set; }
    }
}
