﻿using Microsoft.EntityFrameworkCore;

namespace BethanyPieShop.Models
{
    public class BethanyPieShopDbContext : DbContext
    {
        public BethanyPieShopDbContext(DbContextOptions<BethanyPieShopDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }
    }
}
