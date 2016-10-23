using System;
using System.Linq;
using PilotoQ1Net.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PilotoQ1Net.DataAccess
{
  public class DomainModelContext : DbContext
  {
      public DomainModelContext(DbContextOptions<DomainModelContext> options) : base(options)
      { }

      public DbSet<Content> ContentModel { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
            builder.Entity<Content>().HasKey(m => m.Id);

            // shadow properties
            builder.Entity<Content>().Property<DateTime>("Updated");

            base.OnModelCreating(builder);
      }

      public override int SaveChanges()
      {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
      }
      
  }
}