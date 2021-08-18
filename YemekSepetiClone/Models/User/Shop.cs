using System.Collections.Generic;

namespace YemekSepetiClone.Models.User
{
    public class Shop:User
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public double ServiceQuality { get; set; }
        public double TasteQuality { get; set; }
        public string ImagePath { get; set; }

        public string MinPrice { get; set; }

        public string ServiceTime { get; set; }

        public List<Category> Categories { get; set; } = new();
        public List<Order> RecievedOrders { get; set; } = new();
    }
}