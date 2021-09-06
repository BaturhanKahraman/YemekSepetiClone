using System.ComponentModel.DataAnnotations;

namespace YemekSepetiClone.Models.Dtos.Basket
{
    public class BasketItemDecreaseDto
    {
        [Required(ErrorMessage = "Kullanıcı id'si (customerId) gereklidir.")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "MealId gereklidir.")]
        public int MealId { get; set; }
    }
}