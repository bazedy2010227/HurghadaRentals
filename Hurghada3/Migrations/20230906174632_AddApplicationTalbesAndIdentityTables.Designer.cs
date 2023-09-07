﻿// <auto-generated />
using System;
using Hurghada3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hurghada3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230906174632_AddApplicationTalbesAndIdentityTables")]
    partial class AddApplicationTalbesAndIdentityTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hurghada3.Models.Amenity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("33b03499-7a45-4982-893a-9738b4dde466"),
                            Description = "Air Conditioning"
                        },
                        new
                        {
                            Id = new Guid("90acf5ef-da5c-4d72-80b7-c04612093503"),
                            Description = "Balcony"
                        },
                        new
                        {
                            Id = new Guid("3642939e-000f-4ce6-a9d1-23daab00f3b4"),
                            Description = "Cable TV"
                        },
                        new
                        {
                            Id = new Guid("2ea92b3a-3f81-486f-943b-4bdb3f7ca512"),
                            Description = "Kitchen Applinces"
                        },
                        new
                        {
                            Id = new Guid("4e58783c-3b2b-4f6d-ae57-e7703027586e"),
                            Description = "Swimming Pool"
                        },
                        new
                        {
                            Id = new Guid("bcfacf91-9ca2-4200-a1f3-7b555b55c98a"),
                            Description = "Washer"
                        },
                        new
                        {
                            Id = new Guid("7f105c7d-d470-4255-80b1-216dde6f53ab"),
                            Description = "WiFi"
                        },
                        new
                        {
                            Id = new Guid("7e9a9485-41b9-4fc6-b41c-8e530fb36348"),
                            Description = "LandLine"
                        },
                        new
                        {
                            Id = new Guid("70a8cf22-cac4-43ca-b8e0-a0bbfc566b85"),
                            Description = "Parking"
                        },
                        new
                        {
                            Id = new Guid("ad44b585-7b1f-4dd8-b080-0935a55fd0d4"),
                            Description = "Garden"
                        },
                        new
                        {
                            Id = new Guid("626b8c27-d346-47e3-b0ba-a1f320895388"),
                            Description = "BeachAccess"
                        },
                        new
                        {
                            Id = new Guid("abe4d9d8-64c5-434c-8c02-00474ebf2c0e"),
                            Description = "Pets Allowed"
                        },
                        new
                        {
                            Id = new Guid("dfcb0bfa-12ec-4a51-86b0-b947537a5334"),
                            Description = "Elevator"
                        });
                });

            modelBuilder.Entity("Hurghada3.Models.Apartment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ApartmentTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<int>("BedRooms")
                        .HasColumnType("int");

                    b.Property<int>("DailyPayment")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DownPayment")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFurnished")
                        .HasColumnType("bit");

                    b.Property<Guid>("LevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MonthlyPayment")
                        .HasColumnType("int");

                    b.Property<int>("PathRooms")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentTypeId");

                    b.HasIndex("LevelId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("Hurghada3.Models.ApartmentAmenity", b =>
                {
                    b.Property<Guid>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AmenityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ApartmentId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.ToTable("ApartmentAmenities");
                });

            modelBuilder.Entity("Hurghada3.Models.ApartmentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApartmentTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("be9da45b-6c54-4a33-ac11-680a1957b182"),
                            Name = "Studio"
                        },
                        new
                        {
                            Id = new Guid("8853167a-03f8-4cd9-97a0-b4095625a037"),
                            Name = "Apartment"
                        },
                        new
                        {
                            Id = new Guid("bd7ce40c-218f-4400-bc99-0144f988a2a9"),
                            Name = "Doublex"
                        },
                        new
                        {
                            Id = new Guid("d1a7af99-1ad6-43b7-8d0a-0b449f183585"),
                            Name = "Villa"
                        },
                        new
                        {
                            Id = new Guid("30c9055e-b978-4727-97d3-9a866fa70a90"),
                            Name = "Chalet"
                        },
                        new
                        {
                            Id = new Guid("3dbaf1d5-98ad-4aab-a824-918165405ec8"),
                            Name = "Hotel"
                        },
                        new
                        {
                            Id = new Guid("ec0ab06f-829d-4fb3-b65f-11133d2c36b9"),
                            Name = "Resort"
                        },
                        new
                        {
                            Id = new Guid("3d0cfe66-7ef9-474f-8039-f812881f8bd5"),
                            Name = "House"
                        },
                        new
                        {
                            Id = new Guid("a5adaba3-519e-437e-9f1f-d8439ddf256e"),
                            Name = "Flat"
                        },
                        new
                        {
                            Id = new Guid("a9d6eead-a37f-4c84-b8fa-567457ffce9d"),
                            Name = "Penthouse"
                        },
                        new
                        {
                            Id = new Guid("f8627bf2-41b5-4c88-8209-67e274d1d716"),
                            Name = "Townhouse"
                        });
                });

            modelBuilder.Entity("Hurghada3.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "Security");
                });

            modelBuilder.Entity("Hurghada3.Models.Level", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Levels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("67247927-ffda-426f-a973-32d4f3426ccc"),
                            Name = "Ground Floor"
                        },
                        new
                        {
                            Id = new Guid("3b92dd41-1607-4c7e-810a-cc70d5ae7864"),
                            Name = "First Floor"
                        },
                        new
                        {
                            Id = new Guid("c54d9ff9-0980-4a00-834c-e9cf5abbd13d"),
                            Name = "2nd Floor"
                        },
                        new
                        {
                            Id = new Guid("8029206e-c6db-4570-8d18-7d3a4f7c340f"),
                            Name = "3rd Floor"
                        },
                        new
                        {
                            Id = new Guid("18e11e4f-a9d0-4006-8e9a-a8daa263811a"),
                            Name = "4th Floor"
                        },
                        new
                        {
                            Id = new Guid("18a14c05-c887-4be6-ad4a-5617710ba4ab"),
                            Name = "5th Floor"
                        },
                        new
                        {
                            Id = new Guid("30a6626c-aa95-445f-abab-94baffa24401"),
                            Name = "6th Floor"
                        },
                        new
                        {
                            Id = new Guid("a2f48602-cdee-45bf-b604-7bcdd715b568"),
                            Name = "7th Floor"
                        },
                        new
                        {
                            Id = new Guid("84ce9287-0886-44f1-91dc-5c4465727331"),
                            Name = "8th Floor"
                        },
                        new
                        {
                            Id = new Guid("d30aba68-0935-44a1-b660-99e601bde32d"),
                            Name = "9th Floor"
                        },
                        new
                        {
                            Id = new Guid("60c6366d-896f-4211-b27b-b0bd5972e9ca"),
                            Name = "10th Floor"
                        },
                        new
                        {
                            Id = new Guid("2f02b37b-d903-425e-bc05-cdb830ebb129"),
                            Name = "+10th Floor"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "Security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "Security");
                });

            modelBuilder.Entity("Hurghada3.Models.Apartment", b =>
                {
                    b.HasOne("Hurghada3.Models.ApartmentType", "ApartmentType")
                        .WithMany("Apartments")
                        .HasForeignKey("ApartmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hurghada3.Models.Level", "Level")
                        .WithMany("Apartments")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApartmentType");

                    b.Navigation("Level");
                });

            modelBuilder.Entity("Hurghada3.Models.ApartmentAmenity", b =>
                {
                    b.HasOne("Hurghada3.Models.Amenity", "Amenity")
                        .WithMany()
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hurghada3.Models.Apartment", "Apartment")
                        .WithMany("ApartmentAmenities")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Hurghada3.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hurghada3.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hurghada3.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Hurghada3.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hurghada3.Models.Apartment", b =>
                {
                    b.Navigation("ApartmentAmenities");
                });

            modelBuilder.Entity("Hurghada3.Models.ApartmentType", b =>
                {
                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("Hurghada3.Models.Level", b =>
                {
                    b.Navigation("Apartments");
                });
#pragma warning restore 612, 618
        }
    }
}
