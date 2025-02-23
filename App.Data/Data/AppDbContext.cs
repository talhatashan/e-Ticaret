using App.Data.Data.Entities;
using App.Data.Data.SeedDataClass;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace App.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }

        //public DbSet<CarItemEntity> CarItems { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderItemEntity> OrderItems { get; set; }
        public DbSet<ProductCommentEntity> ProductComments { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductImageEntity> ProductImages { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<UserEntity> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            modelBuilder.Entity<RoleEntity>().HasData(SeedData.GetRoles());
     
            modelBuilder.Entity<UserEntity>().HasData(SeedData.GetUser());

            modelBuilder.Entity<CategoryEntity>().HasData(SeedData.GetCategories());


        }
    }

}
