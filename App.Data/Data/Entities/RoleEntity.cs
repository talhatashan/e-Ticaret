using System.ComponentModel.DataAnnotations;

namespace App.Data.Data.Entities
{
    public class RoleEntity
    {
        [Required]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(10)]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public ICollection<UserEntity> Users { get; set; }
    }
}
