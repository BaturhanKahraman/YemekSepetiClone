namespace YemekSepetiClone.Models.User
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; } = new();
        public string Phone { get; set; }
    }
}