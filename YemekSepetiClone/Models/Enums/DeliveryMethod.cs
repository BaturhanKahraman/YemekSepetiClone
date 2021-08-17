using System.Runtime.Serialization;

namespace YemekSepetiClone.Models.Enums
{
    public enum DeliveryMethod
    {
        [EnumMember(Value = "FromShop")]
        FromShop, 

        [EnumMember(Value = "WithCourier")]
        WithCourier
    }
}