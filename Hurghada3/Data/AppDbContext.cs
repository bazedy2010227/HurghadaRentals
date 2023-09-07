using Microsoft.EntityFrameworkCore;
using Hurghada3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Hurghada3.Data
{
    public class AppDbContext :IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<ApartmentType> ApartmentTypes { get; set; }
        public DbSet<ApartmentAmenity> ApartmentAmenities { get; set; }
        public DbSet<Level> Levels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ////////////////////////////////Security Entities/////////////////////////////////////////
            modelBuilder.Entity<ApplicationUser>().ToTable("Users", "Security");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles", "Security");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Security");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Security");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Security");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Security");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Security");

            ////////////////////////////////Application Entities/////////////////////////////////////////
            modelBuilder.Entity<ApartmentAmenity>().HasKey(aa => new { aa.ApartmentId, aa.AmenityId });
            modelBuilder.Entity<Amenity>().HasData(new List<Amenity>

            {
            new Amenity{Id=Guid.NewGuid(),Description = "Air Conditioning"},
            new Amenity{Id=Guid.NewGuid(),Description = "Balcony"},
            new Amenity{Id=Guid.NewGuid(),Description = "Cable TV"},
            new Amenity{Id=Guid.NewGuid(),Description = "Kitchen Applinces"},
            new Amenity{Id=Guid.NewGuid(),Description = "Swimming Pool"},
            new Amenity{Id=Guid.NewGuid(),Description = "Washer"},
            new Amenity{Id=Guid.NewGuid(),Description = "WiFi"},
            new Amenity{Id=Guid.NewGuid(),Description = "LandLine"},
            new Amenity{Id=Guid.NewGuid(),Description = "Parking"},
            new Amenity{Id=Guid.NewGuid(),Description = "Garden"},
            new Amenity{Id=Guid.NewGuid(),Description = "BeachAccess"},
            new Amenity{Id=Guid.NewGuid(),Description = "Pets Allowed"},
            new Amenity{Id=Guid.NewGuid(),Description = "Elevator"},


            });
            modelBuilder.Entity<Level>().HasData(new Level[]
            {
                new Level{Id=Guid.NewGuid(),Name="Ground Floor"},
                new Level{Id=Guid.NewGuid(),Name="First Floor"},
                new Level{Id=Guid.NewGuid(),Name="2nd Floor"},
                new Level{Id=Guid.NewGuid(),Name="3rd Floor"},
                new Level{Id=Guid.NewGuid(),Name="4th Floor"},
                new Level{Id=Guid.NewGuid(),Name="5th Floor"},
                new Level{Id=Guid.NewGuid(),Name="6th Floor"},
                new Level{Id=Guid.NewGuid(),Name="7th Floor"},
                    
                new Level{Id=Guid.NewGuid(),Name="8th Floor"},
                new Level{Id=Guid.NewGuid(),Name="9th Floor"},
                new Level{Id=Guid.NewGuid(),Name="10th Floor"},
                new Level{Id=Guid.NewGuid(),Name="+10th Floor"},

            });
            modelBuilder.Entity<ApartmentType>().HasData(new ApartmentType[]
            {
                new ApartmentType{Id=Guid.NewGuid(),Name="Studio"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Apartment"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Doublex"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Villa"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Chalet"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Hotel"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Resort"},
                new ApartmentType{Id=Guid.NewGuid(),Name="House"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Flat"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Penthouse"},
                new ApartmentType{Id=Guid.NewGuid(),Name="Townhouse"},

            });



        }
    } 
}
    

