﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shopbeta_server.Infrastructure.Repository;

namespace shopbeta.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210819030549_updateProduct")]
    partial class updateProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "e0e7fa6a-3b7c-4d9b-bcf3-64ec13fb714f",
                            ConcurrencyStamp = "5374fbe2-37d0-4266-ade8-38e7a9c994e4",
                            Name = "Buyer",
                            NormalizedName = "BUYER"
                        },
                        new
                        {
                            Id = "5308eb07-2a92-4d6e-a4c6-894089a39c5b",
                            ConcurrencyStamp = "81045213-9bfb-42f5-b114-c6118b0ff952",
                            Name = "Seller",
                            NormalizedName = "SELLER"
                        },
                        new
                        {
                            Id = "47ce7be0-0f29-4cbe-9c83-c9f6a9086662",
                            ConcurrencyStamp = "aa3c6256-dbcc-4411-9239-aefa6aef9154",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("shopbeta.Core.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            OrderDate = new DateTime(2021, 8, 19, 4, 5, 48, 262, DateTimeKind.Local).AddTicks(9933),
                            OrderNumber = 12345,
                            TotalPrice = 45000
                        });
                });

            modelBuilder.Entity("shopbeta.Core.Models.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Subtotal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("shopbeta.Core.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("SellerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991874"),
                            Category = "Phones",
                            Description = "Phone 12 based on iOS 14 and packs 128GB of inbuilt storage. The iPhone 12 is a SINGLE-SIM (GSM and GSM) smartphone that accepts Nano-SIM and eSIM cards. The iPhone 12 measures 146.70 x 71.50 x 7.40mm (height x width x thickness) and weighs 164.00 grams. It was launched in Black, Blue, Green, Red, and White colours. It features an IP68 rating for dust and water protection.",
                            Name = "Apple Iphone 12",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/63/733376/1.jpg?4732",
                            Price = 500000,
                            SellerName = "Applestore"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991875"),
                            Category = "Laptops",
                            Description = "The Lenovo V15 Its design not only capitalizes on a more flattened and sleeker overall surface. It is ultimately a more distinctly commutable gadget to aid users to boot the system up wherever they wish to go. The Lenovo V15 demonstrates a wide range of versatility when it comes to accomplishing essential tasks pertaining to productivity. First of all, it is worth noting that the monitor of the Lenovo Ideapad ",
                            Name = "Lenovo Intel i3 12GB",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/43/110387/1.jpg?5675",
                            Price = 240000,
                            SellerName = "Slot"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991876"),
                            Category = "Laptops",
                            Description = "Stay connected to what matters most with long-lasting battery life and a thin, micro-edge bezel design. Built to keep you productive and entertained, the HP 15 diagonal laptop features reliable performance and an expansive display - letting you stream, surf and speed through tasks.",
                            Name = "Hp 15 AMD - 8GB RAM 1TB HDD Windows 10 Pro",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/05/771587/1.jpg?2146",
                            Price = 198000,
                            SellerName = "Slot"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991877"),
                            Category = "Laptops",
                            Description = "Stay connected to what matters most with long-lasting battery life and a thin, micro-edge bezel design. Built to keep you productive and entertained, the HP 15 diagonal laptop features reliable performance and an expansive display - letting you stream, surf and speed through tasks.",
                            Name = "DELL Latitude 9410 Convertible Core I7 10th Gen",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/85/976596/1.jpg?0508",
                            Price = 700000,
                            SellerName = "Slot"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991878"),
                            Category = "Gaming",
                            Description = "With extensive improvements upon its best-in-class graphics and gameplay, competitive and community online features, and deep, varied game modes, NBA 2K21 offers one-of-a-kind immersion into all facets of NBA basketball and culture - where Everything is Game. .NBA 2K21 is the latest title in the world-renowned, best-selling NBA 2K series, delivering an industry-leading sports video game experience on PlayStation 4.",
                            Name = "NBA 2k21 PS4",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/96/844556/1.jpg?1648",
                            Price = 11000,
                            SellerName = "GameStation"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991879"),
                            Category = "Gaming",
                            Description = "Your Favorite Franchises Live Here: Dig g a huge catalog of exclusive games, including generation defining titles like entries in popular franchises like .",
                            Name = "Sony Sony Ps4 Console 500 GB WITH 2 CONTROLLER",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/06/151517/1.jpg?4850",
                            Price = 200000,
                            SellerName = "GameStation"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991880"),
                            Category = "Gaming",
                            Description = "Win as One in EA SPORTS FIFA 21, powered by Frostbite. Whether it’s on the streets or in the stadium, FIFA 21 has more ways to play than ever before – including the UEFA Champions League and CONMEBOL Libertadores.",
                            Name = "FIFA 2021 - Playstation 4",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/54/508127/1.jpg?9860",
                            Price = 13000,
                            SellerName = "GameStation"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991881"),
                            Category = "Fashion",
                            Description = "A grateful heart is a blessed heart, show gratitude with our premium quality t-shirt, made with the best quality cotton with comfy feel fabric and quality print. Shop Cura Wears unique and inspiring wears.",
                            Name = "Cura GRATEFUL T-SHIRT (QUALITY COTTON) - BLACK",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/70/386407/1.jpg?1729",
                            Price = 2800,
                            SellerName = "Viki's Makeover"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991882"),
                            Category = "Fashion",
                            Description = "100% Cotton material gives you comfortable feeling with High Quality, Cool, Charming & Fashionable",
                            Name = "6in1 RoundNeck Polo",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/33/215485/1.jpg?8629",
                            Price = 8000,
                            SellerName = "Viki's Makeover"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991883"),
                            Category = "Phones",
                            Description = "The quad-camera setup of the Galaxy A32 opens up a diverse array of opportunities for users to express their creativity through photos. For starters, the 64MP main camera enables users to capture crisp and clear photos throughout the day.The 8MP Ultra - Wide lens has a 123 - degree field of view which adds more perspective to images – perfect for capturing lofty landscapes.",
                            Name = "Samsung Galaxy A32",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/20/832127/1.jpg?7108",
                            Price = 117595,
                            SellerName = "Affordables"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991884"),
                            Category = "Phones",
                            Description = "The combination of 3x Optical Zoom and 30x Super Resolution Zoom let you get a close-up on the scene without moving your feet. Supports approximately 3x optical zoom with 76mm focal length. 30X Space Zoom includes digital zoom, which may cause some image deterioration. Single Take - Shoot it once, get multiple options. All enabled by AI. Shoot for up to 15 seconds and let yon to victory.",
                            Name = "Samsung Galaxy S20 FE 6.5-Inch (6GB 128GB ROM)",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/29/818776/1.jpg?3447",
                            Price = 289880,
                            SellerName = "Affordables"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991885"),
                            Category = "Phones",
                            Description = "Xiaomi Redmi Note 9 is officially released in April 2020. The device is equipped with sensors such as Fingerprint (rear - mounted accelerometer,gyro, proximity, and compass. The smartphone features Infrared port USB 2.0 Type C, Radio with recording, and Bluetooth 5.0.The smartphone is fueled by a Non - removable Li - Po 5020 mAh battery + Fast charging 18W   13 MP sensor",
                            Name = "XIAOMI Redmi Note 9 6.53 Inches 4GB RAM 128GB",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/86/840086/1.jpg?6354",
                            Price = 88450,
                            SellerName = "Shopright"
                        },
                        new
                        {
                            ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991886"),
                            Category = "Phones",
                            Description = "Shoot amazing videos and photos with the Ultra Wide, Wide, and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR movies and shows on the Super Retina XDR display—the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR), and photography. And get all-day battery life¹",
                            Name = "Apple Iphone 11 Pro",
                            Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/88/250536/1.jpg?1190",
                            Price = 400000,
                            SellerName = "Shopright"
                        });
                });

            modelBuilder.Entity("shopbeta.Core.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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
                    b.HasOne("shopbeta.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("shopbeta.Core.Models.User", null)
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

                    b.HasOne("shopbeta.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("shopbeta.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("shopbeta.Core.Models.Order", b =>
                {
                    b.HasOne("shopbeta.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("shopbeta.Core.Models.OrderItem", b =>
                {
                    b.HasOne("shopbeta.Core.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("shopbeta.Core.Models.Product", b =>
                {
                    b.HasOne("shopbeta.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
