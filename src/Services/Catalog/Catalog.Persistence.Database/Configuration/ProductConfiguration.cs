using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            // Configuracion de la tabla
            entityBuilder.HasKey(x => x.ProductId);

            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            entityBuilder.Property(x => x.Price).HasColumnType("decimal");

            // Products by default
            var products = new List<Product>();
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    ProductId = i,
                    Name = $"Product {i}",
                    Description = $"Description {i}",
                    Price = random.Next(100, 1000)
                });
            }

            // Indicando al EntityBuilder que tiene datos semilla
            entityBuilder.HasData(products);
        }
    }
}
