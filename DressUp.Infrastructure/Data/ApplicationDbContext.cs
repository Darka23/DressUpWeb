using DressUp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Bag> Bags { get; set; }

        public DbSet<Cloth> Clothes { get; set; }

        public DbSet<Accessory> Accessories { get; set; }

        public DbSet<Shoe> Shoes { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Material> Materials { get; set; }
    }
}