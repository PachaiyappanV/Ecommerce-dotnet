using System.ComponentModel.DataAnnotations.Schema;
namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        //navigation property for OrderItems
        // a product can be part of multiple order items.
        // This is a one-to-many relationship.
        public ICollection<OrderItem> OrderItems { get; set; }
       
    }
}