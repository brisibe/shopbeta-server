using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbeta.Migrations
{
    public partial class change_user_details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1920b6f2-3395-4bfc-8a41-b5be8997bb7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66858800-416b-4054-8034-2ab614e7a6b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfde55ff-da03-4304-9eff-0e0a3590607a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd508b02-b711-4605-9c54-89d25b4ee587", "f38c469c-9983-4143-a72b-3673c33bf132", "Buyer", "BUYER" },
                    { "4a2420af-8eff-4c37-ad4e-c30cd5236dbd", "6733f4af-415d-41b4-b066-2d89911da7d7", "Seller", "SELLER" },
                    { "088da42d-9685-4396-aa0c-8333d27cfecd", "b52a18e1-b1de-475c-90ae-0428002594a5", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "OrderDate",
                value: new DateTime(2021, 6, 26, 14, 23, 45, 981, DateTimeKind.Local).AddTicks(8980));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "088da42d-9685-4396-aa0c-8333d27cfecd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2420af-8eff-4c37-ad4e-c30cd5236dbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd508b02-b711-4605-9c54-89d25b4ee587");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1920b6f2-3395-4bfc-8a41-b5be8997bb7b", "c29eb39f-4149-4298-b733-572091ea55ef", "Buyer", "BUYER" },
                    { "cfde55ff-da03-4304-9eff-0e0a3590607a", "4c28965d-813d-4294-bfeb-e6cb3983e563", "Seller", "SELLER" },
                    { "66858800-416b-4054-8034-2ab614e7a6b8", "38530e87-26b4-47a8-904a-ac08a19cbc95", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "OrderDate",
                value: new DateTime(2021, 6, 26, 2, 52, 27, 712, DateTimeKind.Local).AddTicks(1430));
        }
    }
}
