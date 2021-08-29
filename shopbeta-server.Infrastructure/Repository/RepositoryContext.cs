using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shopbeta.Core.Models;
using shopbeta_server.Infrastructure.ModelConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta_server.Infrastructure.Repository
{
   public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Order { get; set;  }  
    }
}
 