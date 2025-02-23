using App.Data.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Configurations
{
   
        public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
        {
            public void Configure(EntityTypeBuilder<OrderEntity> builder)
            {
                builder.HasOne(c => c.User)
           .WithMany(u => u.Orders)
           .HasForeignKey(c => c.UserId)
           .OnDelete(DeleteBehavior.NoAction);
            }
        }
    
}
