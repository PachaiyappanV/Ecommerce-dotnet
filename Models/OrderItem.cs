using System.ComponentModel.DataAnnotations.Schema;
namespace Ecommerce.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        // Foreign key and navigation property for Order
        public int OrderId { get; set; }
        public Order Order { get; set; }

        // Foreign key and navigation property for Product
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        //Computed Property
        [NotMapped]
        public decimal Total => Quantity * UnitPrice;
    }
}