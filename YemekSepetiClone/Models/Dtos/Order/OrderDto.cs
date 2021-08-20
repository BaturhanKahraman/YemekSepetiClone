using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekSepetiClone.Models.Dtos.Order
{
    public class OrderDto
    {
        public int UserId { get; set; }

        public List<BasketItem> BasketItems { get; set; }

        public decimal TotalPrice { get; set; }


    }
}
