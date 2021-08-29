using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbeta.Migrations
{
    public partial class newProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44f5f71d-0138-4225-a5bf-566762d9d5eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3ea8a75-aefa-4510-b376-e5c3fa32af69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfd1503b-6206-4042-a3fc-faecc9ae1f37");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d7cd528-21ce-4204-8c44-41103545bd44", "50cce878-73f3-44f1-8ddd-be17d67a6239", "Buyer", "BUYER" },
                    { "63d42049-b910-4ce5-99b8-6f2c6438f94f", "bc074814-d81d-4e84-b8cf-8cf973db7a0c", "Seller", "SELLER" },
                    { "75a4baf9-4d66-44b1-9b2f-9ea77625e212", "007bf3c0-b21f-4145-8a84-b5a6b047c01a", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "OrderDate",
                value: new DateTime(2021, 8, 19, 3, 6, 28, 28, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "Description", "Name", "Photo", "Price", "SellerName" },
                values: new object[] { "The quad-camera setup of the Galaxy A32 opens up a diverse array of opportunities for users to express their creativity through photos. For starters, the 64MP main camera enables users to capture crisp and clear photos throughout the day.The 8MP Ultra - Wide lens has a 123 - degree field of view which adds more perspective to images – perfect for capturing lofty landscapes. Meanwhile, the 5MP Macro lens takes crystal clear close - up shots. Additionally, the 5MP Depth camera gives amazing portrait shots in Portrait mode, while the 20MP front camera enables eye - catching selfies in high clarity – perfect for capturing high-quality social media content. For those looking to take their photography experience to the next level, the Galaxy A32 supports Hyperlapse, Night mode, Slow - mo, Panorama and Pro mode as well.", "Samsung Galaxy A32", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/20/832127/1.jpg?7108", 117595, "Affordables" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"),
                columns: new[] { "Description", "Name", "Photo", "Price", "SellerName" },
                values: new object[] { "The combination of 3x Optical Zoom and 30x Super Resolution Zoom let you get a close-up on the scene without moving your feet. Supports approximately 3x optical zoom with 76mm focal length. 30X Space Zoom includes digital zoom, which may cause some image deterioration. Single Take - Shoot it once, get multiple options. All enabled by AI. Shoot for up to 15 seconds and let your phone do the magic of creating variety of videos, photos and more.Note-The format and amount of Single Take results may differ based on original capture. Single Take requires a minimum of 3 seconds of shooting, up to a maximum of 15 seconds.Night ModeOur biggest dual pixel sensor for vivid, clear night photos. The rear camera on Galaxy S20 FE adjusts to pull in light even when it's dark so your shots come out detailed and colorful.*Galaxy S20 FE dual pixel sensor size is 1.8μm. Super Smooth 120HzTwice as fast as many smartphone screens, the Super AMOLED display refreshes at a super smooth 120Hz to keep action clear and touch response f All-day Intelligent BatteryThe 4500mAh (typical) battery gives your phone the juice it needs to outlast your day, and it's intelligent enough to save its power for when you really need it.Actual battery life may vary depending on network environment, usage patterns and other factors. HyperFast ProcessorOur latest S20 chipset innovation and the enhanced NPU takes performance to a new level, so switching from app to app is seamless, livestreams come through clear, and you've got power enabling you to game on to victory.", "Samsung Galaxy S20 FE 6.5-Inch (6GB 128GB ROM)", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/29/818776/1.jpg?3447", 289880, "Affordables" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"),
                columns: new[] { "Description", "Name", "Photo", "Price", "SellerName" },
                values: new object[] { "Xiaomi Redmi Note 9 is officially released in April 2020. The device is equipped with sensors such as Fingerprint (rear - mounted accelerometer,gyro, proximity, and compass. The smartphone features Infrared port USB 2.0 Type C, Radio with recording, and Bluetooth 5.0.The smartphone is fueled by a Non - removable Li - Po 5020 mAh battery + Fast charging 18W + Reverse charging 9W The phone runs on the Android 10.0 + MIUI 11 operating system providing smooth operation of the device.The Xiaomi Redmi Note 9 is available in different colors like Forest Green, Midnight Grey and Polar White.The smartphone is powered by the MediaTek Helio G85 Octa - core processor while the GPU is Mali - G52 MC2.The smartphone is Splash - proof which makes the users care - free. The smartphone comes in 6.53 inches size and the display is IPS LCD capacitive touchscreen that provides 1080 x 2400 pixels resolution. The screen of the device is protected by Corning Gorilla Glass 5. Additional features support 450 nits typ.brightness(advertised) which gives amazing viewing experience. The rear camera consists of a 48 MP(wide) + 8 MP(ultrawide) + 2 MP(macro) + 2 MP depth sensor lenses that helps to click pictures with professional experience.The front camera has a 13 MP sensor", "XIAOMI Redmi Note 9 6.53 Inches 4GB RAM 128GB", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/86/840086/1.jpg?6354", 88450, "Shopright" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"),
                columns: new[] { "Category", "Description", "Name", "Photo", "Price", "SellerName" },
                values: new object[] { "Phones", "Shoot amazing videos and photos with the Ultra Wide, Wide, and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR movies and shows on the Super Retina XDR display—the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR), and photography. And get all-day battery life¹ and a new level of water resistance.² All in the first iPhone powerful enough to be called Pro.", "Apple Iphone 11 Pro", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/88/250536/1.jpg?1190", 400000, "Shopright" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Name", "Photo", "Price", "SellerName", "UserId" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991875"), "Laptops", "The Lenovo V15 Its design not only capitalizes on a more flattened and sleeker overall surface. It is ultimately a more distinctly commutable gadget to aid users to boot the system up wherever they wish to go. The Lenovo V15 demonstrates a wide range of versatility when it comes to accomplishing essential tasks pertaining to productivity. First of all, it is worth noting that the monitor of the Lenovo Ideapad V15 does not flip all the way to the rear end of the device due to the absence of a standard . However, it can be laid flat on a plain surface without any obstruction, which can be considered as a quirky trait, which can be put into good use.  With immediacy, it can also be noted that the Lenovo Ideapad V15 has a 15.6 inches antiglare display, which is further magnified by thin side bezels. The visuals displayed are further accompanied with an audio system of complimentary caliber all thanks to the appreciated inclusion of Dolby Audio technology.", "Lenovo Intel i3 12GB", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/43/110387/1.jpg?5675", 240000, "Slot", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991876"), "Laptops", "Stay connected to what matters most with long-lasting battery life and a thin, micro-edge bezel design. Built to keep you productive and entertained, the HP 15 diagonal laptop features reliable performance and an expansive display - letting you stream, surf and speed through tasks.", "Hp 15 AMD - 8GB RAM 1TB HDD Windows 10 Pro", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/05/771587/1.jpg?2146", 198000, "Slot", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991877"), "Laptops", "Stay connected to what matters most with long-lasting battery life and a thin, micro-edge bezel design. Built to keep you productive and entertained, the HP 15 diagonal laptop features reliable performance and an expansive display - letting you stream, surf and speed through tasks.", "DELL Latitude 9410 Convertible Core I7 10th Gen", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/85/976596/1.jpg?0508", 700000, "Slot", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991878"), "Gaming", "With extensive improvements upon its best-in-class graphics and gameplay, competitive and community online features, and deep, varied game modes, NBA 2K21 offers one-of-a-kind immersion into all facets of NBA basketball and culture - where Everything is Game. .NBA 2K21 is the latest title in the world-renowned, best-selling NBA 2K series, delivering an industry-leading sports video game experience on PlayStation 4.", "NBA 2k21 PS4", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/96/844556/1.jpg?1648", 11000, "GameStation", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991880"), "Gaming", "Win as One in EA SPORTS FIFA 21, powered by Frostbite. Whether it’s on the streets or in the stadium, FIFA 21 has more ways to play than ever before – including the UEFA Champions League and CONMEBOL Libertadores.", "FIFA 2021 - Playstation 4", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/54/508127/1.jpg?9860", 13000, "GameStation", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991881"), "Fashion", "A grateful heart is a blessed heart, show gratitude with our premium quality t-shirt, made with the best quality cotton with comfy feel fabric and quality print. Shop Cura Wears unique and inspiring wears.", "Cura GRATEFUL T-SHIRT (QUALITY COTTON) - BLACK", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/70/386407/1.jpg?1729", 2800, "Viki's Makeover", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991882"), "Fashion", "100% Cotton material gives you comfortable feeling with High Quality, Cool, Charming & Fashionable", "6in1 RoundNeck Polo", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/33/215485/1.jpg?8629", 8000, "Viki's Makeover", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991874"), "Phones", "Phone 12 based on iOS 14 and packs 128GB of inbuilt storage. The iPhone 12 is a SINGLE-SIM (GSM and GSM) smartphone that accepts Nano-SIM and eSIM cards. The iPhone 12 measures 146.70 x 71.50 x 7.40mm (height x width x thickness) and weighs 164.00 grams. It was launched in Black, Blue, Green, Red, and White colours. It features an IP68 rating for dust and water protection.", "Apple Iphone 12", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/63/733376/1.jpg?4732", 500000, "Apple store", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991879"), "Gaming", "Your Favorite Franchises Live Here: Dig g a huge catalog of exclusive games, including generation defining titles like entries in popular franchises like .", "Sony Sony Ps4 Console 500 GB WITH 2 CONTROLLER", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/06/151517/1.jpg?4850", 200000, "GameStation", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d7cd528-21ce-4204-8c44-41103545bd44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63d42049-b910-4ce5-99b8-6f2c6438f94f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a4baf9-4d66-44b1-9b2f-9ea77625e212");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991874"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991875"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991876"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991877"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991878"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991879"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991880"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991881"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991882"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a3ea8a75-aefa-4510-b376-e5c3fa32af69", "e3fe04ac-dc35-43b8-a8f9-e832ecf95758", "Buyer", "BUYER" },
                    { "cfd1503b-6206-4042-a3fc-faecc9ae1f37", "20c0aab3-f542-4b9d-af6a-7575a1d49bf3", "Seller", "SELLER" },
                    { "44f5f71d-0138-4225-a5bf-566762d9d5eb", "d375e6b3-f3a0-4eda-ae7e-8a9e300a5961", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "OrderDate",
                value: new DateTime(2021, 7, 24, 14, 6, 18, 501, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "Description", "Name", "Photo", "Price", "SellerName" },
                values: new object[] { "A very neat Iphone with two cameras", "Iphone 10 promax", "ps5", 50000, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"),
                columns: new[] { "Description", "Name", "Photo", "Price", "SellerName" },
                values: new object[] { "A very neat Iphone with two cameras", "Iphone 10 promax", "ps5", 50000, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"),
                columns: new[] { "Description", "Name", "Photo", "Price", "SellerName" },
                values: new object[] { "A very neat Iphone with two cameras", "Iphone 10 promax", "ps5", 50000, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"),
                columns: new[] { "Category", "Description", "Name", "Photo", "Price", "SellerName" },
                values: new object[] { "Laptop", "A very neat Iphone with two cameras", "Hp envy", "ps5", 20000, null });
        }
    }
}
