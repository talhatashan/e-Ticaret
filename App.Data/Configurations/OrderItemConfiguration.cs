using App.Data.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItemEntity>
    {
        public void Configure(EntityTypeBuilder<OrderItemEntity> builder)
        {
            builder.Property(p => p.UnitPrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();
            builder.HasOne(oi => oi.Product)
               .WithMany()
               .HasForeignKey(oi => oi.ProductId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
