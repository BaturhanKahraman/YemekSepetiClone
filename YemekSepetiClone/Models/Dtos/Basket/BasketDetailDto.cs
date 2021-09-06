using System.Collections.Generic;

namespace YemekSepetiClone.Models.Dtos.Basket
{
    public class BasketDetailDto
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public int TotalQuantity { get; set; }

        public List<BasketItemDto> BasketItems { get; set; }
    }
}