using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopbeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta_server.Infrastructure.ModelConfigurations
{
   public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                
                      
                            new Product
                            {
                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991874"),
                                Name = "Apple Iphone 12",
                                Category = "Phones",
                                Description = "Phone 12 based on iOS 14 and packs 128GB of inbuilt storage. The iPhone 12 is a SINGLE-SIM (GSM and GSM) smartphone that accepts Nano-SIM and eSIM cards. The iPhone 12 measures 146.70 x 71.50 x 7.40mm (height x width x thickness) and weighs 164.00 grams. It was launched in Black, Blue, Green, Red, and White colours. It features an IP68 rating for dust and water protection.",
                                Price = 500000,
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/63/733376/1.jpg?4732",
                                SellerName = "Applestore"
                            },
                            new Product
                            {
                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991875"),
                                Name = "Lenovo Intel i3 12GB",
                                Category = "Laptops",
                                Price = 240000,
                                Description = "The Lenovo V15 Its design not only capitalizes on a more flattened and sleeker overall surface. It is ultimately a more distinctly commutable gadget to aid users to boot the system up wherever they wish to go. The Lenovo V15 demonstrates a wide range of versatility when it comes to accomplishing essential tasks pertaining to productivity. First of all, it is worth noting that the monitor of the Lenovo Ideapad ",
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/43/110387/1.jpg?5675",
                                SellerName = "Slot"

                            },
                            new Product
                            {
                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991876"),
                                Name = "Hp 15 AMD - 8GB RAM 1TB HDD Windows 10 Pro",
                                Category = "Laptops",
                                Price = 198000,
                                Description = "Stay connected to what matters most with long-lasting battery life and a thin, micro-edge bezel design. Built to keep you productive and entertained, the HP 15 diagonal laptop features reliable performance and an expansive display - letting you stream, surf and speed through tasks.",
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/05/771587/1.jpg?2146",
                                SellerName = "Slot"

                            },
                            new Product
                            {

                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991877"),
                                Name = "DELL Latitude 9410 Convertible Core I7 10th Gen",
                                Category = "Laptops",
                                Price = 700000,
                                Description = "Stay connected to what matters most with long-lasting battery life and a thin, micro-edge bezel design. Built to keep you productive and entertained, the HP 15 diagonal laptop features reliable performance and an expansive display - letting you stream, surf and speed through tasks.",
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/85/976596/1.jpg?0508",
                                SellerName = "Slot"

                            },
                            new Product
                            {
                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991878"),
                                Name = "NBA 2k21 PS4",
                                Category = "Gaming",
                                Price = 11000,
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/96/844556/1.jpg?1648",
                                SellerName = "GameStation",
                                Description = "With extensive improvements upon its best-in-class graphics and gameplay, competitive and community online features, and deep, varied game modes, NBA 2K21 offers one-of-a-kind immersion into all facets of NBA basketball and culture - where Everything is Game. .NBA 2K21 is the latest title in the world-renowned, best-selling NBA 2K series, delivering an industry-leading sports video game experience on PlayStation 4."

                            },
                            new Product
                            {
                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991879"),
                                Name = "Sony Sony Ps4 Console 500 GB WITH 2 CONTROLLER",
                                Category = "Gaming",
                                Price = 200000,
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/06/151517/1.jpg?4850",
                                SellerName = "GameStation",
                                Description = "Your Favorite Franchises Live Here: Dig g a huge catalog of exclusive games, including generation defining titles like entries in popular franchises like ."
                            },
                            new Product
                            {

                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991880"),
                                Name = "FIFA 2021 - Playstation 4",
                                Category = "Gaming",
                                Price = 13000,
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/54/508127/1.jpg?9860",
                                SellerName = "GameStation",
                                Description = "Win as One in EA SPORTS FIFA 21, powered by Frostbite. Whether it’s on the streets or in the stadium, FIFA 21 has more ways to play than ever before – including the UEFA Champions League and CONMEBOL Libertadores."

 
                            }, 
                            new Product
                            {

                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991881"),
                                Name = "Cura GRATEFUL T-SHIRT (QUALITY COTTON) - BLACK",
                                Category = "Fashion",
                                Price = 2800,
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/70/386407/1.jpg?1729",
                                SellerName = "Viki's Makeover",
                                Description = "A grateful heart is a blessed heart, show gratitude with our premium quality t-shirt, made with the best quality cotton with comfy feel fabric and quality print. Shop Cura Wears unique and inspiring wears."


                            },
                             new Product
                             {

                                 ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991882"),
                                 Name = "6in1 RoundNeck Polo",
                                 Category = "Fashion",
                                 Price = 8000,
                                 Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/33/215485/1.jpg?8629",
                                 SellerName = "Viki's Makeover",
                                 Description = "100% Cotton material gives you comfortable feeling with High Quality, Cool, Charming & Fashionable"
                             },
                             new Product
                             {
                                 ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991883"),
                                 Name = "Samsung Galaxy A32",
                                 Category = "Phones",
                                 Description = "The quad-camera setup of the Galaxy A32 opens up a diverse array of opportunities for users to express their creativity through photos. For starters, the 64MP main camera enables users to capture crisp and clear photos throughout the day.The 8MP Ultra - Wide lens has a 123 - degree field of view which adds more perspective to images – perfect for capturing lofty landscapes.",
                                 Price = 117595,
                                 Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/20/832127/1.jpg?7108",
                                 SellerName = "Affordables"
                             },
                            new Product
                            {
                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991884"),
                                Name = "Samsung Galaxy S20 FE 6.5-Inch (6GB 128GB ROM)",
                                Category = "Phones",
                                Description = "The combination of 3x Optical Zoom and 30x Super Resolution Zoom let you get a close-up on the scene without moving your feet. Supports approximately 3x optical zoom with 76mm focal length. 30X Space Zoom includes digital zoom, which may cause some image deterioration. Single Take - Shoot it once, get multiple options. All enabled by AI. Shoot for up to 15 seconds and let yon to victory.",
                                Price = 289880,
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/29/818776/1.jpg?3447",
                                SellerName = "Affordables"
                            },
                            new Product
                            {
                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991885"),
                                Name = "XIAOMI Redmi Note 9 6.53 Inches 4GB RAM 128GB",
                                Category = "Phones",
                                Description = "Xiaomi Redmi Note 9 is officially released in April 2020. The device is equipped with sensors such as Fingerprint (rear - mounted accelerometer,gyro, proximity, and compass. The smartphone features Infrared port USB 2.0 Type C, Radio with recording, and Bluetooth 5.0.The smartphone is fueled by a Non - removable Li - Po 5020 mAh battery + Fast charging 18W   13 MP sensor",
                                Price = 88450,
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/86/840086/1.jpg?6354",
                                SellerName = "Shopright"
                            },
                            new Product
                            {
                                ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991886"),
                                Name = "Apple Iphone 11 Pro",
                                Category = "Phones",
                                Description = "Shoot amazing videos and photos with the Ultra Wide, Wide, and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR movies and shows on the Super Retina XDR display—the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR), and photography. And get all-day battery life¹",
                                Price = 400000,
                                Photo = "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/88/250536/1.jpg?1190",
                                SellerName = "Shopright"
                            }

                );
        }
    }
}
