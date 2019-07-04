using System;
using Microsoft.EntityFrameworkCore;

using GrapeApe.Client.Common;

namespace GrapeApe.Client.Data {

  public class ClientDbContext : DbContext {

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("dbConnectionString"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

      modelBuilder.Entity<Streamer>(entity => {

        // keys
        entity.HasKey(pk => pk.Id);

        // properties
        entity.Property(p => p.Id)
              .IsRequired();

        entity.Property(p => p.DateCreated)
              .IsRequired();

        entity.Property(p => p.AccountStatus)
              .IsRequired();
      });
    }

    public DbSet<Streamer> Streamers { get; set; }
  }
}
