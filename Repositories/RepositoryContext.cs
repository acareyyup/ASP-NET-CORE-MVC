﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData(
                new Product() { Id = 1, ProductName = "Computer", Price = 17_500 },
                new Product() { Id = 2, ProductName = "Keyboard", Price = 1_00 },
                new Product() { Id = 3, ProductName = "Mouse", Price = 500 },
                new Product() { Id = 4, ProductName = "Monitor", Price = 7_000 },
                new Product() { Id = 5, ProductName = "Deck", Price = 1_500 },
                new Product() { Id = 6, ProductName = "Camera", Price = 2_000 }
                );

            modelBuilder.Entity<Category>()
                .HasData(
                new Category() { Id = 1, CategoryName = "Book" },
                new Category() { Id = 2, CategoryName = "Electronic" }
                );


        }


    }
}
