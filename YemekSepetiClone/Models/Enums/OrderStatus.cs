using System.Runtime.Serialization;

namespace YemekSepetiClone.Models.Enums
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Successful")]
        Successful,
        [EnumMember(Value = "Cancelled")]
        Cancelled
    }
}