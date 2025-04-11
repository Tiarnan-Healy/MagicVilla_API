using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<Villa>().HasData(new Villa()
            {
                Id = 1,
                Name = "Royal Villa",
                Occupancy = 5,
                SqFt = 550,
                Rate = 200,
                ImageUrl = "",
                Amenity = "",
                Details = "Details about Royal Villa. Lorem ipsum dolor sit amet.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 2,
                Name = "Luxury Villa",
                Occupancy = 4,
                SqFt = 450,
                Rate = 150,
                ImageUrl = "",
                Amenity = "",
                Details = "Details about Luxury Villa. Lorem ipsum dolor sit amet.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }, 
            new Villa()
            {
                Id = 3,
                Name = "Deluxe Villa",
                Occupancy = 3,
                SqFt = 350,
                Rate = 100,
                ImageUrl = "",
                Amenity = "",
                Details = "Details about Deluxe Villa. Lorem ipsum dolor sit amet.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Villa ()
            {
                Id = 4,
                Name = "Standard Villa",
                Occupancy = 2,
                SqFt = 250,
                Rate = 80,
                ImageUrl = "",
                Amenity = "",
                Details = "Details about Standard Villa. Lorem ipsum dolor sit amet.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 5,
                Name = "Premium Villa",
                Occupancy = 6,
                SqFt = 600,
                Rate = 250,
                ImageUrl = "",
                Amenity = "",
                Details = "Details about Premium Villa. Lorem ipsum dolor sit amet.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });

            modelBuilder.Entity<User>().HasData(new
            {
                Id = 1,
                Username = "admin",
                Password = "admin123",
                IsWebUser = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },

            new User()
            {
                Id = 2,
                Username = "admin2",
                Password = "admin123",
                IsWebUser = false,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });
        }
    }

    //// Design-time factory for EF CLI tools
    //public class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    //{
    //    public ApplicationDBContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();

    //        IConfigurationRoot configuration = new ConfigurationBuilder()
    //            .SetBasePath(AppContext.BaseDirectory)
    //            .AddJsonFile("appsettings.json")
    //            .Build();

    //        var connectionString = configuration.GetConnectionString("DefaultSQLConnection");

    //        optionsBuilder.UseSqlServer(connectionString);

    //        return new ApplicationDBContext(optionsBuilder.Options);
    //    }
    //}
}
