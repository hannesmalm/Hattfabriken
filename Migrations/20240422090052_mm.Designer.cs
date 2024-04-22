﻿// <auto-generated />
using System;
using Hattfabriken.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hattfabriken.Migrations
{
    [DbContext(typeof(HatDbContext))]
    [Migration("20240422090052_mm")]
    partial class mm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hattfabriken.Models.Customer", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Hattfabriken.Models.Hat", b =>
                {
                    b.Property<int>("HatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HatId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OuterMeasurement")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SpecialEffects")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HatId");

                    b.HasIndex("MaterialName");

                    b.ToTable("Hats");
                });

            modelBuilder.Entity("Hattfabriken.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Hattfabriken.Models.Material", b =>
                {
                    b.Property<string>("MaterialName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaterialQuantity")
                        .HasColumnType("int");

                    b.Property<string>("MaterialSupplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("MaterialName");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            MaterialName = "Leather",
                            MaterialQuantity = 1000,
                            MaterialSupplier = "Leather@gmail.com",
                            Price = 45
                        },
                        new
                        {
                            MaterialName = "Straw",
                            MaterialQuantity = 800,
                            MaterialSupplier = "StrawSwag@icloud.com",
                            Price = 14
                        },
                        new
                        {
                            MaterialName = "Cloth",
                            MaterialQuantity = 2200,
                            MaterialSupplier = "ClothCircus@hotmail.com",
                            Price = 13
                        },
                        new
                        {
                            MaterialName = "Snakeskin",
                            MaterialQuantity = 400,
                            MaterialSupplier = "SnakeKiller@icloud.com",
                            Price = 84
                        },
                        new
                        {
                            MaterialName = "Felt",
                            MaterialQuantity = 600,
                            MaterialSupplier = "FeltFear@icloud.com",
                            Price = 14
                        },
                        new
                        {
                            MaterialName = "Panama",
                            MaterialQuantity = 900,
                            MaterialSupplier = "PanamaSwag@icloud.com",
                            Price = 16
                        },
                        new
                        {
                            MaterialName = "Cotton",
                            MaterialQuantity = 200,
                            MaterialSupplier = "CottonCorner@icloud.com",
                            Price = 16
                        },
                        new
                        {
                            MaterialName = "Linen",
                            MaterialQuantity = 300,
                            MaterialSupplier = "GrischLaidback@icloud.com",
                            Price = 28
                        },
                        new
                        {
                            MaterialName = "Satin",
                            MaterialQuantity = 1000,
                            MaterialSupplier = "SatinSwag@icloud.com",
                            Price = 12
                        },
                        new
                        {
                            MaterialName = "Polyester",
                            MaterialQuantity = 2900,
                            MaterialSupplier = "PolyesterChina@icloud.com",
                            Price = 11
                        });
                });

            modelBuilder.Entity("Hattfabriken.Models.Offer", b =>
                {
                    b.Property<int>("OffertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OffertId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryOrPickup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstimatedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HatType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HatmakerComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MaterialCost")
                        .HasColumnType("float");

                    b.Property<int>("Measurement")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<double?>("ShippingCost")
                        .HasColumnType("float");

                    b.Property<double?>("SpecialEffectCost")
                        .HasColumnType("float");

                    b.Property<string>("SpecialEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<bool>("Urgent")
                        .HasColumnType("bit");

                    b.HasKey("OffertId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Hattfabriken.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Commentary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Delivery")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("HatImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("HatType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Maker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Measurement")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("SpecialEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Köpmansgatan 10",
                            Commentary = "Beställningen brådskar.",
                            Country = "Sverige",
                            Date = new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = true,
                            Email = "kund@example.com",
                            Height = 10,
                            Maker = "Otto",
                            Material = "Leather",
                            Measurement = 58,
                            Name = "Kund Namnsson",
                            PhoneNumber = "0701234567",
                            PostalCode = 12345,
                            SpecialEffects = "[\"Waterproof\"]",
                            Status = "To-Do"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Handelsgatan 20",
                            Commentary = "Extra storlek behövs.",
                            Country = "Sverige",
                            Date = new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = false,
                            Email = "annan.kund@example.com",
                            Height = 8,
                            Maker = "Judith",
                            Material = "Straw",
                            Measurement = 60,
                            Name = "Annan Kundsson",
                            PhoneNumber = "0707654321",
                            PostalCode = 23456,
                            SpecialEffects = "[\"Sunproof\"]",
                            Status = "Judith-Ongoing"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Blommans väg 3",
                            Commentary = "Behöver för sommarsäsongen.",
                            Country = "Sverige",
                            Date = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = true,
                            Email = "sommar@example.com",
                            Height = 9,
                            Maker = "Greta",
                            Material = "Cotton",
                            Measurement = 57,
                            Name = "Sommar Svensson",
                            PhoneNumber = "0712345678",
                            PostalCode = 34567,
                            SpecialEffects = "[\"Lightweight\"]",
                            Status = "To-Do"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Vintergatan 45",
                            Commentary = "Vinterdesign önskas.",
                            Country = "Sverige",
                            Date = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = false,
                            Email = "vinter@example.com",
                            Height = 12,
                            Maker = "Hugo",
                            Material = "Wool",
                            Measurement = 59,
                            Name = "Vinter Vintersson",
                            PhoneNumber = "0723456789",
                            PostalCode = 45678,
                            SpecialEffects = "[\"Insulated\"]",
                            Status = "To-Do"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Glamourgatan 12",
                            Commentary = "För speciell gala.",
                            Country = "Sverige",
                            Date = new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = true,
                            Email = "gala@example.com",
                            Height = 7,
                            Maker = "Freja",
                            Material = "Silk",
                            Measurement = 56,
                            Name = "Gala Galesson",
                            PhoneNumber = "0734567890",
                            PostalCode = 56789,
                            SpecialEffects = "[\"Shiny\"]",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Snabbvägen 30",
                            Commentary = "Snabb leverans krävs.",
                            Country = "Sverige",
                            Date = new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = true,
                            Email = "snabb@example.com",
                            Height = 10,
                            Maker = "Otto",
                            Material = "Felt",
                            Measurement = 55,
                            Name = "Snabb Snabbsson",
                            PhoneNumber = "0745678901",
                            PostalCode = 67890,
                            SpecialEffects = "[\"Stiff\"]",
                            Status = "To-Do"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Retrogatan 56",
                            Commentary = "Retrostil önskas.",
                            Country = "Sverige",
                            Date = new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = false,
                            Email = "retro@example.com",
                            Height = 11,
                            Maker = "Judith",
                            Material = "Leather",
                            Measurement = 61,
                            Name = "Retro Retrosson",
                            PhoneNumber = "0756789012",
                            PostalCode = 78901,
                            SpecialEffects = "[\"Vintage\"]",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Solgatan 78",
                            Commentary = "Lätt och luftig för sommarbruk.",
                            Country = "Sverige",
                            Date = new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = true,
                            Email = "solig@example.com",
                            Height = 9,
                            Maker = "Greta",
                            Material = "Straw",
                            Measurement = 58,
                            Name = "Solig Solsson",
                            PhoneNumber = "0767890123",
                            PostalCode = 89012,
                            SpecialEffects = "[\"Breathable\"]",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Fiskevägen 89",
                            Commentary = "Vattenavvisande för fiske.",
                            Country = "Sverige",
                            Date = new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delivery = false,
                            Email = "fiskare@example.com",
                            Height = 8,
                            Maker = "Hugo",
                            Material = "Polyester",
                            Measurement = 62,
                            Name = "Fiskare Fiskarsson",
                            PhoneNumber = "0778901234",
                            PostalCode = 90123,
                            SpecialEffects = "[\"Waterproof\"]",
                            Status = "Completed"
                        });
                });

            modelBuilder.Entity("Hattfabriken.Models.QuantityRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RequestedQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialName");

                    b.ToTable("QuantityRequests");
                });

            modelBuilder.Entity("Hattfabriken.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Commentary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryOrPickup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HatType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Measurement")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OuterMeasurement")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<byte[]>("RequestImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SpecialEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Urgent")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Hattfabriken.Models.SpecialEffects", b =>
                {
                    b.Property<string>("SpecialEffectName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("SpecialEffectName");

                    b.ToTable("SpecialEffects");
                });

            modelBuilder.Entity("Hattfabriken.Models.User", b =>
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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2b6b8470-f906-4e5d-8b1e-ff49786b6e28",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8a53cc1c-f2be-4272-b41e-0c297605465f",
                            Email = "otto@hattfabriken.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OTTO@HATTFABRIKEN.COM",
                            NormalizedUserName = "OTTO@HATTFABRIKEN.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPBXdpiWxCCtcqT6mGHXuWIRvqGTt8Lr6zcEZdp6WRTP7HIn8K9wRpuqHFGmGUuTPw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d6c9985a-c705-473f-94f9-52d6fe66be25",
                            TwoFactorEnabled = false,
                            UserName = "otto@hattfabriken.com"
                        },
                        new
                        {
                            Id = "a36abcfe-b62a-4358-8745-5bf2b4b751ec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2292a838-9325-4117-a472-fd431579ae05",
                            Email = "judith@hattfabriken.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JUDITH@HATTFABRIKEN.COM",
                            NormalizedUserName = "JUDITH@HATTFABRIKEN.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEG8K9/V+ESH0Id9DEEjvHSq7NuzElLjIa2+5R7wyrY8n8xxIMNRQ7XIOoPA9CxO8vQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d62f708a-b9a4-4cff-9b02-685c648c972d",
                            TwoFactorEnabled = false,
                            UserName = "judith@hattfabriken.com"
                        });
                });

            modelBuilder.Entity("Hattfabriken.Models.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseId"));

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quanitity")
                        .HasColumnType("int");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");
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

                    b.ToTable("AspNetRoles", (string)null);
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

                    b.ToTable("AspNetRoleClaims", (string)null);
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

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Hattfabriken.Models.Hat", b =>
                {
                    b.HasOne("Hattfabriken.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Hattfabriken.Models.QuantityRequest", b =>
                {
                    b.HasOne("Hattfabriken.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
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
                    b.HasOne("Hattfabriken.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hattfabriken.Models.User", null)
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

                    b.HasOne("Hattfabriken.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Hattfabriken.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
