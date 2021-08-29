using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbeta.Migrations
{
    public partial class updateordertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "OrderNumber",
                table: "Order",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9cc6b16f-647b-4819-8d69-43b287c22e95", "2ebb4ec9-9cdf-4f89-8bc7-b90869d56880", "Buyer", "BUYER" },
                    { "84d75978-9738-4bdc-8a9c-34b2df6131dd", "24e5c9d4-9fb1-4d31-b28c-980d8dcf2a4c", "Seller", "SELLER" },
                    { "6de1ea75-08ed-4f9c-b845-e5dc8946fec6", "f2fc3fef-2c5a-412d-a613-a2da7406eb28", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "OrderDate", "OrderNumber" },
                values: new object[] { new DateTime(2021, 6, 28, 3, 55, 25, 689, DateTimeKind.Local).AddTicks(3698), 12345 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6de1ea75-08ed-4f9c-b845-e5dc8946fec6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84d75978-9738-4bdc-8a9c-34b2df6131dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cc6b16f-647b-4819-8d69-43b287c22e95");

            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

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
                columns: new[] { "OrderDate", "OrderNumber" },
                values: new object[] { new DateTime(2021, 6, 26, 14, 23, 45, 981, DateTimeKind.Local).AddTicks(8980), "12345" });
        }
    }
}
