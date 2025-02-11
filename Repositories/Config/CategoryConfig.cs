﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CategoryName).IsRequired();

            builder.HasData(
                new Category() { Id = 1, CategoryName = "Book" },
                new Category() { Id = 2, CategoryName = "Electronic" }
            );
        }
    }
}
