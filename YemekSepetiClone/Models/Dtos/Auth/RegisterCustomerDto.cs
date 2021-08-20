namespace YemekSepetiClone.Models.Dtos.Auth
{
    public class RegisterCustomerDto:RegisterDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}