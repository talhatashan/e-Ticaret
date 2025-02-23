using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Data.Entities
{
    public class OrderEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        [Required, MinLength(2)]
        public string OrderCode { get; set; }
        [Required, MinLength(2), MaxLength(250)]
        public string Address { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public ICollection<OrderItemEntity> OrderItems { get; set; }
    }
}
