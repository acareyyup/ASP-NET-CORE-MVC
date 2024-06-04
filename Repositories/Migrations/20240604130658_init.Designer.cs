﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240604130658_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 17500m,
                            ProductName = "Computer"
                        },
                        new
                        {
                            Id = 2,
                            Price = 100m,
                            ProductName = "Keyboard"
                        },
                        new
                        {
                            Id = 3,
                            Price = 500m,
                            ProductName = "Mouse"
                        },
                        new
                        {
                            Id = 4,
                            Price = 7000m,
                            ProductName = "Monitor"
                        },
                        new
                        {
                            Id = 5,
                            Price = 1500m,
                            ProductName = "Deck"
                        },
                        new
                        {
                            Id = 6,
                            Price = 2000m,
                            ProductName = "Camera"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
