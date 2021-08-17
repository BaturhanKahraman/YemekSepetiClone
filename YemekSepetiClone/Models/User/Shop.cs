using System.Collections.Generic;

namespace YemekSepetiClone.Models.User
{
    public class Shop:User
    {
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string ImagePath { get; set; }
        public List<Category> Categories { get; set; } = new();
        public List<Order> RecievedOrders { get; set; } = new();
    }
}