using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Data.Entities
{
    public class UserEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; } 

        [Required, MinLength(2), MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string LastName { get; set; }

        [Required, MinLength(1)]
        public string Password { get; set; }

        [Required]
       
        public int RoleId { get; set; }
        public RoleEntity Role { get; set; }

        [Required]
        public bool Enabled { get; set; } = true;

        [Required]
        public DateTime CreatedAt { get; set; }
        public ICollection<CarItemEntity> CarItems { get; set; }
        public ICollection<OrderEntity> Orders { get; set; }
        public ICollection<ProductCommentEntity> ProductComments { get; set; }
        public ICollection<ProductEntity> Products { get; set; }

    }
}
