using System.Security.AccessControl;

namespace YemekSepetiClone.Models.Dtos.Auth
{
    public class RegisterShopDto:RegisterDto
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public double ServiceQuality { get; set; }
        public double TasteQuality { get; set; }
        public string ImagePath { get; set; }

        public string MinPrice { get; set; }

        public string ServiceTime { get; set; }
    }
}