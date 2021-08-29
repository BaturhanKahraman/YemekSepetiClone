using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Models
{
    public class Basket
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<BasketItem> BasketItems { get; set; } 
    }
}