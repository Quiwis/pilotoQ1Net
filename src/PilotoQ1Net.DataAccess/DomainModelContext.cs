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
      public DbSet<Job> JobModel { get; set; }
      public DbSet<Permision> PermisionModel { get; set; }
      public DbSet<Profile> ProfileModel { get; set; }
      public DbSet<User> UserModel { get; set; }
      public DbSet<OrganizationalUnit> OrganizationalUnitModel { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
            builder.Entity<Content>().HasKey(m => m.Id);
            builder.Entity<Job>().HasKey(m => m.Id);
            builder.Entity<User>().HasKey(m => m.Id);
            builder.Entity<OrganizationalUnit>().HasKey(m => m.Id);
            builder.Entity<Permision>().HasKey(m => m.Id);
            builder.Entity<Profile>().HasKey(m => m.Id);
            // shadow properties

            builder.Entity<Content>().Property<DateTime>("Updated");
            builder.Entity<Job>().Property<DateTime>("Created");
            builder.Entity<User>().Property<DateTime>("Created");
            builder.Entity<OrganizationalUnit>().Property<DateTime>("Created");
            builder.Entity<Permision>().Property<DateTime>("Created");
            builder.Entity<Profile>().Property<DateTime>("Created");

            base.OnModelCreating(builder);
      }

      public override int SaveChanges()
      {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
      }
      
  }
}