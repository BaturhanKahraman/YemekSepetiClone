using System.Collections.Generic;

namespace YemekSepetiClone.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Meal> Meals { get; set; } = new();
    }
}