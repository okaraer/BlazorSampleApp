using BlazorApp.Data.Entities;
using BlazorApp.Data.FakeData;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorApp.Data
{
    public class BlazorAppDbContext : DbContext
    {

        protected readonly IConfiguration _configuration;


        public BlazorAppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;

        }



        public DbSet<Personel> Personel { get; set; }
        public DbSet<Firmalar> Firmalar { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(_configuration.GetConnectionString("Default"));
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            FakeSeedData.Init();
            modelBuilder.Entity<Firmalar>().HasData(FakeSeedData.Firma);
            modelBuilder.Entity<Personel>().HasData(FakeSeedData.Personel);

        }



    }
}