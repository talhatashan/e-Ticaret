using App.Data.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Configurations
{
    
        public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
        {
            public void Configure(EntityTypeBuilder<UserEntity> builder)
            {
                builder.HasOne(c => c.Role)
           .WithMany(u => u.Users)
           .HasForeignKey(c => c.RoleId)
           .OnDelete(DeleteBehavior.NoAction);

            }
        }
    
}
