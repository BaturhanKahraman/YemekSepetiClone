namespace YemekSepetiClone.Models.Dtos.Meal
{
    public class MealAddDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
    }
}