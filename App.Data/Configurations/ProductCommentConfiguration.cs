using App.Data.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Configurations
{
        public class ProductCommentConfiguration : IEntityTypeConfiguration<ProductCommentEntity>
        {
            public void Configure(EntityTypeBuilder<ProductCommentEntity> builder)
            {
                builder.HasOne(c => c.Product)
           .WithMany(u => u.ProductComments)
           .HasForeignKey(c => c.ProductId)
           .OnDelete(DeleteBehavior.NoAction);

                builder.HasOne(c => c.User)
           .WithMany(p => p.ProductComments)
           .HasForeignKey(c => c.UserId)
           .OnDelete(DeleteBehavior.NoAction);

            }
        }
    
}
