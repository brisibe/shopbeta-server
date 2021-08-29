using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopbeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta_server.Infrastructure.ModelConfigurations
{
   public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                OrderDate = DateTime.Now,
                OrderNumber = 12345,
                TotalPrice = 45000,
            });
        }
    }
}
