using System.ComponentModel.DataAnnotations.Schema;

namespace YemekSepetiClone.Models
{
    public class BasketItem
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
    }
}