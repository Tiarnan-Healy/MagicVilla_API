﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsWebUser")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("SqFt")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7087),
                            Details = "Details about Royal Villa. Lorem ipsum dolor sit amet.",
                            ImageUrl = "",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            SqFt = 550,
                            UpdatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7130)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7133),
                            Details = "Details about Luxury Villa. Lorem ipsum dolor sit amet.",
                            ImageUrl = "",
                            Name = "Luxury Villa",
                            Occupancy = 4,
                            Rate = 150.0,
                            SqFt = 450,
                            UpdatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7134)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7136),
                            Details = "Details about Deluxe Villa. Lorem ipsum dolor sit amet.",
                            ImageUrl = "",
                            Name = "Deluxe Villa",
                            Occupancy = 3,
                            Rate = 100.0,
                            SqFt = 350,
                            UpdatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7137)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7139),
                            Details = "Details about Standard Villa. Lorem ipsum dolor sit amet.",
                            ImageUrl = "",
                            Name = "Standard Villa",
                            Occupancy = 2,
                            Rate = 80.0,
                            SqFt = 250,
                            UpdatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7140)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7142),
                            Details = "Details about Premium Villa. Lorem ipsum dolor sit amet.",
                            ImageUrl = "",
                            Name = "Premium Villa",
                            Occupancy = 6,
                            Rate = 250.0,
                            SqFt = 600,
                            UpdatedDate = new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7144)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
