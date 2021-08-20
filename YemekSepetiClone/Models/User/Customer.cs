using System.Collections.Generic;
using System.Security.AccessControl;

namespace YemekSepetiClone.Models.User
{
    public class Customer:User
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public List<Order> GivenOrders { get; set; } = new();
    }
}