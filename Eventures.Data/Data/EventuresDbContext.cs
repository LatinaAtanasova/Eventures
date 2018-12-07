using System;
using System.Collections.Generic;
using System.Text;
using Eventures.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Data.Data
{
    public class EventuresDbContext : IdentityDbContext<EventuresUser>
    {
        public EventuresDbContext(DbContextOptions<EventuresDbContext> options)
            : base(options)
        {
        }

        public DbSet<EventuresUser> EventuresUsers { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<CustomLog> Logs { get; set; }

        public DbSet<Order> Orders { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Order>()
                .HasOne<Event>(e => e.Event)
                .WithMany(o => o.Orders)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Order>()
                .HasOne<EventuresUser>(e => e.Customer)
                .WithMany(o => o.Orders)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
