using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Data.Entities
{
    public class CarItemEntity
    {
        [Required]
        public int Id { get; set; }

       
        public int UserId { get; set; }

        public UserEntity User { get; set; }

       
        public int ProductId { get; set; }     
        public ProductEntity Product { get; set; }

        [Required, MinLength(1)]
        public byte Quantity { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
