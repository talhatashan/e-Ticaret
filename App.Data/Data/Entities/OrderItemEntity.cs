using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Data.Entities
{
    public class OrderItemEntity
    {
        [Required]
        public int Id { get; set; }

        
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }

      
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }

        [Required, MinLength(1)]
        public byte Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
