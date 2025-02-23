using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Data.Entities
{
    public class ProductCommentEntity
    {
        [Required]
        public int Id { get; set; }

    
       
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }

  
       
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        [Required, MinLength(2), MaxLength(500)]
        public string Text { get; set; }
        [Required, MinLength(1), MaxLength(5)]
        public byte StarCount { get; set; }
        [Required]
        public bool IsConfirmed { get; set; } = false;

        public DateTime CreatedAt { get; set; }

    }
}
