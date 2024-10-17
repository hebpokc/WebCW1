using DataAccess.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Admin>()
                .HasKey(a => a.Id);

            builder.Entity<Admin>()
                .HasOne(a => a.User)
                .WithOne(u => u.Admin)
                .HasForeignKey<Admin>(a => a.UserId);

            builder.Entity<Computer>()
                .HasKey(c => c.Id);

            builder.Entity<Group>()
                .HasKey(g => g.Id);

            builder.Entity<Group>()
                .HasOne(g => g.User)
                .WithMany(u => u.Groups)
                .HasForeignKey(g => g.UserId);

            builder.Entity<Reservation>()
                .HasKey(r => r.Id);

            builder.Entity<Reservation>()
                .HasMany(r => r.Users)
                .WithMany(u => u.Reservations);

            builder.Entity<Reservation>()
                .HasOne(r => r.Computer)
                .WithMany()
                .HasForeignKey(r => r.ComputerId);

            base.OnModelCreating(builder);
        }

    }
}
