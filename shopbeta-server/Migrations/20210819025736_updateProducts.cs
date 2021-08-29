using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbeta.Migrations
{
    public partial class updateProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e02b3e42-25bb-4a38-af4f-3f591b2d6553", "cb07766a-86ff-4854-a8e6-9d27b8ff76fc", "Buyer", "BUYER" },
                    { "97929e9c-6c56-44ab-8b67-964198206739", "9ba38aab-38b1-4f0b-9f3b-047778a69731", "Seller", "SELLER" },
                    { "fa430498-d4e0-45dc-b892-0a60e3fe6c51", "05505dd8-6f97-448b-80bb-ab753fa51e8f", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "OrderDate",
                value: new DateTime(2021, 8, 19, 3, 57, 35, 299, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "Description",
                value: "The quad-camera setup of the Galaxy A32 opens up a diverse array of opportunities for users to express their creativity through photos. For starters, the 64MP main camera enables users to capture crisp and clear photos throughout the day.The 8MP Ultra - Wide lens has a 123 - degree field of view which adds more perspective to images – perfect for capturing lofty landscapes.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"),
                column: "Description",
                value: "The combination of 3x Optical Zoom and 30x Super Resolution Zoom let you get a close-up on the scene without moving your feet. Supports approximately 3x optical zoom with 76mm focal length. 30X Space Zoom includes digital zoom, which may cause some image deterioration. Single Take - Shoot it once, get multiple options. All enabled by AI. Shoot for up to 15 seconds and let yon to victory.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"),
                column: "Description",
                value: "Xiaomi Redmi Note 9 is officially released in April 2020. The device is equipped with sensors such as Fingerprint (rear - mounted accelerometer,gyro, proximity, and compass. The smartphone features Infrared port USB 2.0 Type C, Radio with recording, and Bluetooth 5.0.The smartphone is fueled by a Non - removable Li - Po 5020 mAh battery + Fast charging 18W   13 MP sensor");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"),
                column: "Description",
                value: "Shoot amazing videos and photos with the Ultra Wide, Wide, and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR movies and shows on the Super Retina XDR display—the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR), and photography. And get all-day battery life¹");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991874"),
                column: "SellerName",
                value: "Applestore");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991875"),
                column: "Description",
                value: "The Lenovo V15 Its design not only capitalizes on a more flattened and sleeker overall surface. It is ultimately a more distinctly commutable gadget to aid users to boot the system up wherever they wish to go. The Lenovo V15 demonstrates a wide range of versatility when it comes to accomplishing essential tasks pertaining to productivity. First of all, it is worth noting that the monitor of the Lenovo Ideapad ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97929e9c-6c56-44ab-8b67-964198206739");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e02b3e42-25bb-4a38-af4f-3f591b2d6553");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa430498-d4e0-45dc-b892-0a60e3fe6c51");

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
                column: "Description",
                value: "The quad-camera setup of the Galaxy A32 opens up a diverse array of opportunities for users to express their creativity through photos. For starters, the 64MP main camera enables users to capture crisp and clear photos throughout the day.The 8MP Ultra - Wide lens has a 123 - degree field of view which adds more perspective to images – perfect for capturing lofty landscapes. Meanwhile, the 5MP Macro lens takes crystal clear close - up shots. Additionally, the 5MP Depth camera gives amazing portrait shots in Portrait mode, while the 20MP front camera enables eye - catching selfies in high clarity – perfect for capturing high-quality social media content. For those looking to take their photography experience to the next level, the Galaxy A32 supports Hyperlapse, Night mode, Slow - mo, Panorama and Pro mode as well.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"),
                column: "Description",
                value: "The combination of 3x Optical Zoom and 30x Super Resolution Zoom let you get a close-up on the scene without moving your feet. Supports approximately 3x optical zoom with 76mm focal length. 30X Space Zoom includes digital zoom, which may cause some image deterioration. Single Take - Shoot it once, get multiple options. All enabled by AI. Shoot for up to 15 seconds and let your phone do the magic of creating variety of videos, photos and more.Note-The format and amount of Single Take results may differ based on original capture. Single Take requires a minimum of 3 seconds of shooting, up to a maximum of 15 seconds.Night ModeOur biggest dual pixel sensor for vivid, clear night photos. The rear camera on Galaxy S20 FE adjusts to pull in light even when it's dark so your shots come out detailed and colorful.*Galaxy S20 FE dual pixel sensor size is 1.8μm. Super Smooth 120HzTwice as fast as many smartphone screens, the Super AMOLED display refreshes at a super smooth 120Hz to keep action clear and touch response f All-day Intelligent BatteryThe 4500mAh (typical) battery gives your phone the juice it needs to outlast your day, and it's intelligent enough to save its power for when you really need it.Actual battery life may vary depending on network environment, usage patterns and other factors. HyperFast ProcessorOur latest S20 chipset innovation and the enhanced NPU takes performance to a new level, so switching from app to app is seamless, livestreams come through clear, and you've got power enabling you to game on to victory.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"),
                column: "Description",
                value: "Xiaomi Redmi Note 9 is officially released in April 2020. The device is equipped with sensors such as Fingerprint (rear - mounted accelerometer,gyro, proximity, and compass. The smartphone features Infrared port USB 2.0 Type C, Radio with recording, and Bluetooth 5.0.The smartphone is fueled by a Non - removable Li - Po 5020 mAh battery + Fast charging 18W + Reverse charging 9W The phone runs on the Android 10.0 + MIUI 11 operating system providing smooth operation of the device.The Xiaomi Redmi Note 9 is available in different colors like Forest Green, Midnight Grey and Polar White.The smartphone is powered by the MediaTek Helio G85 Octa - core processor while the GPU is Mali - G52 MC2.The smartphone is Splash - proof which makes the users care - free. The smartphone comes in 6.53 inches size and the display is IPS LCD capacitive touchscreen that provides 1080 x 2400 pixels resolution. The screen of the device is protected by Corning Gorilla Glass 5. Additional features support 450 nits typ.brightness(advertised) which gives amazing viewing experience. The rear camera consists of a 48 MP(wide) + 8 MP(ultrawide) + 2 MP(macro) + 2 MP depth sensor lenses that helps to click pictures with professional experience.The front camera has a 13 MP sensor");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"),
                column: "Description",
                value: "Shoot amazing videos and photos with the Ultra Wide, Wide, and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR movies and shows on the Super Retina XDR display—the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR), and photography. And get all-day battery life¹ and a new level of water resistance.² All in the first iPhone powerful enough to be called Pro.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991874"),
                column: "SellerName",
                value: "Apple store");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991875"),
                column: "Description",
                value: "The Lenovo V15 Its design not only capitalizes on a more flattened and sleeker overall surface. It is ultimately a more distinctly commutable gadget to aid users to boot the system up wherever they wish to go. The Lenovo V15 demonstrates a wide range of versatility when it comes to accomplishing essential tasks pertaining to productivity. First of all, it is worth noting that the monitor of the Lenovo Ideapad V15 does not flip all the way to the rear end of the device due to the absence of a standard . However, it can be laid flat on a plain surface without any obstruction, which can be considered as a quirky trait, which can be put into good use.  With immediacy, it can also be noted that the Lenovo Ideapad V15 has a 15.6 inches antiglare display, which is further magnified by thin side bezels. The visuals displayed are further accompanied with an audio system of complimentary caliber all thanks to the appreciated inclusion of Dolby Audio technology.");
        }
    }
}
