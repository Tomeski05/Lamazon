using Lamazon.Domain.Enums;
using Lamazon.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lamazon.DataAccess
{
    public class LamazonDb : IdentityDbContext<User>
    {
        public LamazonDb(DbContextOptions options)
        : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }


        public void Seed(ModelBuilder modelBuilder)
        {
            //SEED USERS USING IDENTITY MANAGER AS AUTHENTICATION 
            string adminId = Guid.NewGuid().ToString();
            string roleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string filipUserId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Id = roleId,
                        Name = "admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole
                    {
                        Id = userRoleId,
                        Name = "user",
                        NormalizedName = "USER"
                    }
                );


            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = adminId,
                        UserName = "admin",
                        NormalizedUserName = "ADMIN",
                        Email = "lamazon@supply.com",
                        NormalizedEmail = "lamazon@supply.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "Admin123#"),
                        SecurityStamp = string.Empty
                    },
                    new User
                    {
                        Id = filipUserId,
                        FullName = "Filip Tomeski",
                        UserName = "filip.tomeski",
                        NormalizedUserName = "FILIP.TOMESKI",
                        Email = "filip@mail.com",
                        NormalizedEmail = "FILIP@MAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "customer123"),
                        SecurityStamp = string.Empty
                    }
                );

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = roleId,
                        UserId = adminId
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = userRoleId,
                        UserId = filipUserId
                    }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, DateOfOrder = DateTime.UtcNow, Status = StatusType.Init, UserId = filipUserId },
                new Order { Id = 2, DateOfOrder = DateTime.UtcNow, Status = StatusType.Pending, UserId = filipUserId }
           );
                

            modelBuilder.Entity<Product>()
                 .HasData(
                 new Product() { Id = 1, Name = "Samsung A40", Price = 200, Description = "Very good phone. Bad batery", Category = CategoryType.Electronics },
                 new Product() { Id = 2, Name = "Samsung A50", Price = 400, Description = "Very good phone.", Category = CategoryType.Electronics },
                 new Product() { Id = 3, Name = "Samsung A60", Price = 360, Description = "Awesome camera.", Category = CategoryType.Electronics },
                 new Product() { Id = 4, Name = "Samsung Galaxy S7", Price = 200, Description = "Has a lot of memory.", Category = CategoryType.Electronics },
                 new Product() { Id = 5, Name = "Samsung Galaxy S7 edgde", Price = 280, Description = "Awesome screen.", Category = CategoryType.Electronics },
                 new Product() { Id = 6, Name = "Samsung Galaxy S8", Price = 400, Description = "Revolution.", Category = CategoryType.Electronics },
                 new Product() { Id = 7, Name = "Samsung Galaxy S9", Price = 450, Description = "Connecting people.", Category = CategoryType.Electronics },
                 new Product() { Id = 8, Name = "Samsung Galaxy S10", Price = 800, Description = "Very big screen.", Category = CategoryType.Electronics },
                 new Product() { Id = 9, Name = "IPhone 7", Price = 100, Description = "Bad battery.", Category = CategoryType.Electronics },
                 new Product() { Id = 10, Name = "IPhone 8", Price = 400, Description = "It;s very light.", Category = CategoryType.Electronics },
                 new Product() { Id = 11, Name = "IPhone 9", Price = 450, Description = "Great phone.", Category = CategoryType.Electronics },
                 new Product() { Id = 12, Name = "IPhone 10", Price = 900, Description = "Has air pods.", Category = CategoryType.Electronics },
                 new Product() { Id = 13, Name = "C# in depth", Price = 80, Description = "Great book.", Category = CategoryType.Books },
                 new Product() { Id = 14, Name = "Head first C#", Price = 45, Description = "Learn well.", Category = CategoryType.Books },
                 new Product() { Id = 15, Name = "Learn C# in one day", Price = 30, Description = "For beginners.", Category = CategoryType.Books },
                 new Product() { Id = 16, Name = "The C# Player's Guide", Price = 50, Description = "Getting started.", Category = CategoryType.Books },
                 new Product() { Id = 17, Name = "Pro C# 7: With .NET", Price = 25, Description = "For intermediate.", Category = CategoryType.Books },
                 new Product() { Id = 18, Name = "Software Architecture with C# 9 and .NET 5", Price = 75, Description = "Architecting Software.", Category = CategoryType.Books },
                 new Product() { Id = 19, Name = "Professional ASP.NET MVC 5", Price = 70, Description = "The latest version of MVC.", Category = CategoryType.Books }

                 );

            modelBuilder.Entity<ProductOrder>().HasData(
             //Order 1
             new ProductOrder { Id = 1, OrderId = 1, ProductId = 1 },
             new ProductOrder { Id = 2, OrderId = 1, ProductId = 3 },
             new ProductOrder { Id = 3, OrderId = 1, ProductId = 5 },

             //Order 2
             new ProductOrder { Id = 4, OrderId = 2, ProductId = 1 },
             new ProductOrder { Id = 5, OrderId = 2, ProductId = 2 }
         );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductOrder>()
                .HasKey(po => new { po.ProductId, po.OrderId });

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.ProductOrders)
                .WithOne(po => po.Order)
                .HasForeignKey(po => po.OrderId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductOrders)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductId);

            Seed(modelBuilder);
        }
    }
}
