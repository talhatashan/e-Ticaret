using App.Data.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Configurations
{
    
        public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImageEntity>
        {
            public void Configure(EntityTypeBuilder<ProductImageEntity> builder)
            {
   
                builder.HasOne(c => c.Product)
           .WithMany(p => p.ProductImages)
           .HasForeignKey(c => c.ProductId)
           .OnDelete(DeleteBehavior.NoAction);

            }
        }
    
}
