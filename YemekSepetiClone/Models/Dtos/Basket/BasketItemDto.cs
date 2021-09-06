namespace YemekSepetiClone.Models.Dtos.Basket
{
    public class BasketItemDto  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Explanation { get; set; }
        public string ImagePath { get; set; }

    }
}