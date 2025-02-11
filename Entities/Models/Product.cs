﻿namespace Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public String? Summary { get; set; } = String.Empty;
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; set; }        // Foreign Key
        public Category? Category { get; set; }     // Navigation property
        public bool ShowCase { get; set; }
    }
}
