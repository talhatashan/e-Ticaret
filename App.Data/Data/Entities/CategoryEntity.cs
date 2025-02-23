using System.ComponentModel.DataAnnotations;

namespace App.Data.Data.Entities
{
    public class CategoryEntity
    {
        [Required]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(100)]
        public string Name { get; set; }

        [Required, MinLength(3), MaxLength(6)]
        public string Color { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string IconCssClass { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
        
    }
}
