using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace YemekSepetiClone.Models.Dtos.Basket
{
    public class BasketItemAddDto
    {
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int MealId { get; set; }
    }
}