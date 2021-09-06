using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public decimal TotalPrice => BasketItems.Sum(x => x.Price * x.Quantity);
        public int TotalQuantity => BasketItems.Sum(x => x.Quantity);
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<BasketItem> BasketItems { get; set; } 
    }
}