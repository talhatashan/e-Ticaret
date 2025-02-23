using App.Data.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Configurations
{
    public class CarItemConfiguration : IEntityTypeConfiguration<CarItemEntity>
    {
        public void Configure(EntityTypeBuilder<CarItemEntity> builder)
        {
            builder.HasOne(c => c.User)
       .WithMany(u => u.CarItems)
       .HasForeignKey(c => c.UserId)
       .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Product)
       .WithMany(p => p.CarItems)
       .HasForeignKey(c => c.ProductId)
       .OnDelete(DeleteBehavior.NoAction);



        }
    }
    
        
    
}
