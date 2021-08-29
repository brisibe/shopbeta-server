using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbeta.Migrations
{
    public partial class updateProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e0e7fa6a-3b7c-4d9b-bcf3-64ec13fb714f", "5374fbe2-37d0-4266-ade8-38e7a9c994e4", "Buyer", "BUYER" },
                    { "5308eb07-2a92-4d6e-a4c6-894089a39c5b", "81045213-9bfb-42f5-b114-c6118b0ff952", "Seller", "SELLER" },
                    { "47ce7be0-0f29-4cbe-9c83-c9f6a9086662", "aa3c6256-dbcc-4411-9239-aefa6aef9154", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "OrderDate",
                value: new DateTime(2021, 8, 19, 4, 5, 48, 262, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Name", "Photo", "Price", "SellerName", "UserId" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991883"), "Phones", "The quad-camera setup of the Galaxy A32 opens up a diverse array of opportunities for users to express their creativity through photos. For starters, the 64MP main camera enables users to capture crisp and clear photos throughout the day.The 8MP Ultra - Wide lens has a 123 - degree field of view which adds more perspective to images – perfect for capturing lofty landscapes.", "Samsung Galaxy A32", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/20/832127/1.jpg?7108", 117595, "Affordables", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991884"), "Phones", "The combination of 3x Optical Zoom and 30x Super Resolution Zoom let you get a close-up on the scene without moving your feet. Supports approximately 3x optical zoom with 76mm focal length. 30X Space Zoom includes digital zoom, which may cause some image deterioration. Single Take - Shoot it once, get multiple options. All enabled by AI. Shoot for up to 15 seconds and let yon to victory.", "Samsung Galaxy S20 FE 6.5-Inch (6GB 128GB ROM)", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/29/818776/1.jpg?3447", 289880, "Affordables", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991885"), "Phones", "Xiaomi Redmi Note 9 is officially released in April 2020. The device is equipped with sensors such as Fingerprint (rear - mounted accelerometer,gyro, proximity, and compass. The smartphone features Infrared port USB 2.0 Type C, Radio with recording, and Bluetooth 5.0.The smartphone is fueled by a Non - removable Li - Po 5020 mAh battery + Fast charging 18W   13 MP sensor", "XIAOMI Redmi Note 9 6.53 Inches 4GB RAM 128GB", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/86/840086/1.jpg?6354", 88450, "Shopright", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991886"), "Phones", "Shoot amazing videos and photos with the Ultra Wide, Wide, and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR movies and shows on the Super Retina XDR display—the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR), and photography. And get all-day battery life¹", "Apple Iphone 11 Pro", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/88/250536/1.jpg?1190", 400000, "Shopright", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47ce7be0-0f29-4cbe-9c83-c9f6a9086662");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5308eb07-2a92-4d6e-a4c6-894089a39c5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0e7fa6a-3b7c-4d9b-bcf3-64ec13fb714f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991883"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991884"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991885"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991886"));

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Name", "Photo", "Price", "SellerName", "UserId" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Phones", "The quad-camera setup of the Galaxy A32 opens up a diverse array of opportunities for users to express their creativity through photos. For starters, the 64MP main camera enables users to capture crisp and clear photos throughout the day.The 8MP Ultra - Wide lens has a 123 - degree field of view which adds more perspective to images – perfect for capturing lofty landscapes.", "Samsung Galaxy A32", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/20/832127/1.jpg?7108", 117595, "Affordables", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), "Phones", "The combination of 3x Optical Zoom and 30x Super Resolution Zoom let you get a close-up on the scene without moving your feet. Supports approximately 3x optical zoom with 76mm focal length. 30X Space Zoom includes digital zoom, which may cause some image deterioration. Single Take - Shoot it once, get multiple options. All enabled by AI. Shoot for up to 15 seconds and let yon to victory.", "Samsung Galaxy S20 FE 6.5-Inch (6GB 128GB ROM)", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/29/818776/1.jpg?3447", 289880, "Affordables", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"), "Phones", "Xiaomi Redmi Note 9 is officially released in April 2020. The device is equipped with sensors such as Fingerprint (rear - mounted accelerometer,gyro, proximity, and compass. The smartphone features Infrared port USB 2.0 Type C, Radio with recording, and Bluetooth 5.0.The smartphone is fueled by a Non - removable Li - Po 5020 mAh battery + Fast charging 18W   13 MP sensor", "XIAOMI Redmi Note 9 6.53 Inches 4GB RAM 128GB", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/86/840086/1.jpg?6354", 88450, "Shopright", null },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"), "Phones", "Shoot amazing videos and photos with the Ultra Wide, Wide, and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR movies and shows on the Super Retina XDR display—the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR), and photography. And get all-day battery life¹", "Apple Iphone 11 Pro", "https://ng.jumia.is/unsafe/fit-in/680x680/filters:fill(white)/product/88/250536/1.jpg?1190", 400000, "Shopright", null }
                });
        }
    }
}
