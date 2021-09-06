using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace YemekSepetiClone.Models.Dtos.Basket
{
    public class BasketItemAddDto
    {
        [Required(ErrorMessage = "Kullanıcı id'si (customerId) gereklidir.")]
        public int CustomerId { get; set; }
        public int Quantity { get; set; } = 1;
        [Required(ErrorMessage = "MealId gereklidir.")]
        public int MealId { get; set; }
    }
}