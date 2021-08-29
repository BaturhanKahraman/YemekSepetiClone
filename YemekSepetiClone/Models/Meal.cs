using System.ComponentModel.DataAnnotations.Schema;

namespace YemekSepetiClone.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountPercentage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Explanation { get; set; }
        public bool IsActive { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}