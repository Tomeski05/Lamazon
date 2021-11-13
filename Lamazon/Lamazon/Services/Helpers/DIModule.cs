using Lamazon.DataAccess;
using Lamazon.DataAccess.Interfaces;
using Lamazon.DataAccess.Repositories;
using Lamazon.Domain.Models;
using Lamazon.Services.Interfaces;
using Lamazon.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lamazon.Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LamazonDbContext>
                (options => options.UseSqlServer(connectionString));

            services
            .AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireNonAlphanumeric = false;
            })
            .AddRoleManager<RoleManager<IdentityRole>>()
            .AddEntityFrameworkStores<LamazonDbContext>()
            .AddDefaultTokenProviders();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Product>, ProductRepository>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IProductService, ProductService>();


            return services;
        }
    }
}
