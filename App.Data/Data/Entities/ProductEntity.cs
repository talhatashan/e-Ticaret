using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Data.Entities
{
    public class ProductEntity
    {
        [Required]
        public int Id { get; set; }

       
        public int SellerId { get; set; }
        public UserEntity Seller { get; set; }

     
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        [Required, MinLength(2), MaxLength(100)]
        public string Name { get; set; }


        
        public decimal Price { get; set; }

        [MaxLength(1000)]
        public string Details { get; set; }

        [Required]
        public byte StockAmount { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public bool Enabled { get; set; } = true;

        public ICollection<CarItemEntity> CarItems { get; set; }
        public ICollection<OrderItemEntity> OrderItems { get; set; }
        public ICollection<ProductCommentEntity> ProductComments { get; set; }
        public ICollection<ProductImageEntity> ProductImages { get; set; }
        
    }
}
