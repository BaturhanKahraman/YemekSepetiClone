﻿namespace YemekSepetiClone.Models.User
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; } 
        public string Phone { get; set; }
    }
}