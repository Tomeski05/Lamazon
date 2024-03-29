﻿// <auto-generated />
using System;
using Lamazon.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lamazon.DataAccess.Migrations
{
    [DbContext(typeof(LamazonDb))]
    partial class LamazonDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lamazon.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfOrder");

                    b.Property<bool>("IsPaid");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new { Id = 1, DateOfOrder = new DateTime(2021, 11, 17, 15, 17, 25, 687, DateTimeKind.Utc), IsPaid = false, Status = 0, UserId = "029cbbd8-9420-4d2e-9aa8-05ae9597af27" },
                        new { Id = 2, DateOfOrder = new DateTime(2021, 11, 17, 15, 17, 25, 687, DateTimeKind.Utc), IsPaid = false, Status = 1, UserId = "029cbbd8-9420-4d2e-9aa8-05ae9597af27" }
                    );
                });

            modelBuilder.Entity("Lamazon.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, Category = 0, Description = "Very good phone. Bad batery", Name = "Samsung A40", Price = 200.0 },
                        new { Id = 2, Category = 0, Description = "Very good phone.", Name = "Samsung A50", Price = 400.0 },
                        new { Id = 3, Category = 0, Description = "Awesome camera.", Name = "Samsung A60", Price = 360.0 },
                        new { Id = 4, Category = 0, Description = "Has a lot of memory.", Name = "Samsung Galaxy S7", Price = 200.0 },
                        new { Id = 5, Category = 0, Description = "Awesome screen.", Name = "Samsung Galaxy S7 edgde", Price = 280.0 },
                        new { Id = 6, Category = 0, Description = "Revolution.", Name = "Samsung Galaxy S8", Price = 400.0 },
                        new { Id = 7, Category = 0, Description = "Connecting people.", Name = "Samsung Galaxy S9", Price = 450.0 },
                        new { Id = 8, Category = 0, Description = "Very big screen.", Name = "Samsung Galaxy S10", Price = 800.0 },
                        new { Id = 9, Category = 0, Description = "Bad battery.", Name = "IPhone 7", Price = 100.0 },
                        new { Id = 10, Category = 0, Description = "It;s very light.", Name = "IPhone 8", Price = 400.0 },
                        new { Id = 11, Category = 0, Description = "Great phone.", Name = "IPhone 9", Price = 450.0 },
                        new { Id = 12, Category = 0, Description = "Has air pods.", Name = "IPhone 10", Price = 900.0 },
                        new { Id = 13, Category = 1, Description = "Great book.", Name = "C# in depth", Price = 80.0 },
                        new { Id = 14, Category = 1, Description = "Learn well.", Name = "Head first C#", Price = 45.0 },
                        new { Id = 15, Category = 1, Description = "For beginners.", Name = "Learn C# in one day", Price = 30.0 },
                        new { Id = 16, Category = 1, Description = "Getting started.", Name = "The C# Player's Guide", Price = 50.0 },
                        new { Id = 17, Category = 1, Description = "For intermediate.", Name = "Pro C# 7: With .NET", Price = 25.0 },
                        new { Id = 18, Category = 1, Description = "Architecting Software.", Name = "Software Architecture with C# 9 and .NET 5", Price = 75.0 },
                        new { Id = 19, Category = 1, Description = "The latest version of MVC.", Name = "Professional ASP.NET MVC 5", Price = 70.0 }
                    );
                });

            modelBuilder.Entity("Lamazon.Domain.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("OrderId");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ProductId", "OrderId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductOrders");

                    b.HasData(
                        new { ProductId = 1, OrderId = 1, Id = 1 },
                        new { ProductId = 3, OrderId = 1, Id = 2 },
                        new { ProductId = 5, OrderId = 1, Id = 3 },
                        new { ProductId = 1, OrderId = 2, Id = 4 },
                        new { ProductId = 2, OrderId = 2, Id = 5 }
                    );
                });

            modelBuilder.Entity("Lamazon.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "ec212817-df63-4339-b09f-6f6ff1b59367", AccessFailedCount = 0, ConcurrencyStamp = "e82c633b-072e-4064-9ceb-2da8e8327387", Email = "lamazon@supply.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "lamazon@supply.com", NormalizedUserName = "ADMIN", PasswordHash = "AQAAAAEAACcQAAAAEJvEBjHbZyX2JZlpMaCL4gWtnfb+mynHr1bIXvLynjDZlTs7CYHMcSzR1XK0oKNjSQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "admin" },
                        new { Id = "029cbbd8-9420-4d2e-9aa8-05ae9597af27", AccessFailedCount = 0, ConcurrencyStamp = "56fee32f-0a79-432c-8410-cb613a30daeb", Email = "filip@mail.com", EmailConfirmed = true, FullName = "Filip Tomeski", LockoutEnabled = false, NormalizedEmail = "FILIP@MAIL.COM", NormalizedUserName = "FILIP.TOMESKI", PasswordHash = "AQAAAAEAACcQAAAAEP9R1zEg3wn+vlSnu9qkhYcvnm8c2yESim18fP6BsL3jHbXbYy474VR6nBRJeqe+GQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "filip.tomeski" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "8c5f2be5-71b6-4ac3-84b4-de3e4f4ebcf5", ConcurrencyStamp = "c0f40dd5-5ee5-47b6-bbc6-b3f9c3c39071", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "6e1477ce-1c82-4434-a98a-5e62358211d9", ConcurrencyStamp = "215f3d24-935f-4972-b2b3-17aa26b3dd55", Name = "user", NormalizedName = "USER" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "ec212817-df63-4339-b09f-6f6ff1b59367", RoleId = "8c5f2be5-71b6-4ac3-84b4-de3e4f4ebcf5" },
                        new { UserId = "029cbbd8-9420-4d2e-9aa8-05ae9597af27", RoleId = "6e1477ce-1c82-4434-a98a-5e62358211d9" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Lamazon.Domain.Models.Order", b =>
                {
                    b.HasOne("Lamazon.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Lamazon.Domain.Models.ProductOrder", b =>
                {
                    b.HasOne("Lamazon.Domain.Models.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lamazon.Domain.Models.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
