using DeviceManagerBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Constants;

namespace DeviceManagerBackend.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
       
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Room>().HasMany(x => x.);
        //}
    }
}
