using App.Data.Data.Entities;

namespace App.Data.Data.SeedDataClass
{
    public class SeedData
    {
        public static List<RoleEntity> GetRoles()
        {
            return new List<RoleEntity>
            {
                new RoleEntity { Id = 1, Name = "Seller", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0) },
                new RoleEntity { Id = 2, Name = "Buyer", CreatedAt = new DateTime(2024, 2, 3, 1, 0, 0) },
                new RoleEntity { Id = 3, Name = "Admin", CreatedAt = new DateTime(2024, 4, 5, 5, 0, 0) }
            };
        }

        public static UserEntity GetUser()
        {
            return new UserEntity
            {
                Id = 1,
                Email = "admin@admin.com",
                FirstName = "Admin",
                LastName = "Adminovic",
                Password = "123qwer",
                RoleId = 3,
                Enabled = true,
                CreatedAt = new DateTime(1996, 1, 1, 0, 0, 0)
            };
        }

        public static List<CategoryEntity> GetCategories()
        {
            return new List<CategoryEntity>
            {
                new CategoryEntity
                {
                    Id = 1,
                    Name = "Mobilya",
                    Color = "Beyaz",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 2,
                    Name = "Teknoloji",
                    Color = "Beyaz",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 3,
                    Name = "Et",
                    Color = "Beyaz",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 4,
                    Name = "Sut ",
                    Color = "Beyaz",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 5,
                    Name = "At",
                    Color = "Beyaz",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 6,
                    Name = "Kirmizi Et",
                    Color = "Beyaz",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 7,
                    Name = "Kangal Sucuk",
                    Color = "Mor",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 8,
                    Name = "Mangal Sucuk",
                    Color = "Mavi",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 9,
                    Name = "Sut Urunleri",
                    Color = "Beyaz",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                }, new CategoryEntity
                {
                    Id = 10,
                    Name = "Sut Urunleri",
                    Color = "Beyaz",
                    IconCssClass = "blabla",
                    CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0)
                },
            };
        }

        
    }

    
}
