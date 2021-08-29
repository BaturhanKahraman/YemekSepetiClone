using System.Collections.Generic;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.Models
{
    public class Category
    {
        
        public int Id { get; set; }

        public string Name { get; set; }


        public int? ShopId { get; set; }

        public Shop Shop { get; set; }

        public List<Meal> Meals { get; set; }


    }
}