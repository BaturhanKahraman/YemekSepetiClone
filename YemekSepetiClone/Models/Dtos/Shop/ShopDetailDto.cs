using System.Collections.Generic;

namespace YemekSepetiClone.Models.Dtos.Shop
{
    public class ShopDetailDto
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public List<Models.Category> Categories { get; set; }
        public double Speed { get; set; }
        public double ServiceQuality { get; set; }
        public double TasteQuality { get; set; }
        public string ImagePath { get; set; }

    }
}