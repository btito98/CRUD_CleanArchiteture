using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.EntityConfigurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Caderno",
                    Description = "Caderno do Flamengo 200 folhas",
                    Price = 10.45m
                },
                new Product
                {
                    Id = 2,
                    Name = "Celular",
                    Description = "Iphone 2023 roxo",
                    Price = 1000.45m
                },
                new Product
                {
                    Id = 3,
                    Name = "Notebook",
                    Description = "i7 Dell",
                    Price = 200.45m
                }
                );
        }
    }
}
