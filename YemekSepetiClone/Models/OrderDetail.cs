using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace YemekSepetiClone.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public string ItemName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ItemPrice { get; set; }
        
    }
}