using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Data.Entities
{
    public class ProductImageEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }

        [Required, DataType(DataType.Url), MinLength(10), MaxLength(250)]
        public string Url { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

    }
}
