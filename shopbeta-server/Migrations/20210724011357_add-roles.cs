using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbeta.Migrations
{
    public partial class addroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d10763d-a491-4ba2-bd35-dba7f1f8cd54", "04a2010e-ce5e-46e5-a62d-ca9cb927fd5d", "Buyer", "BUYER" },
                    { "d3da04f1-2744-4e8c-9181-af298be89268", "0a6102f0-df51-4972-a41f-1c7581b0a6a9", "Seller", "SELLER" },
                    { "a3355eaa-67db-42df-8a8b-05b309aa9084", "42f3deaf-6a7c-4831-8aa5-8f5bc8a1b386", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "OrderDate",
                value: new DateTime(2021, 7, 24, 2, 13, 56, 515, DateTimeKind.Local).AddTicks(9704));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d10763d-a491-4ba2-bd35-dba7f1f8cd54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3355eaa-67db-42df-8a8b-05b309aa9084");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3da04f1-2744-4e8c-9181-af298be89268");

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
                column: "OrderDate",
                value: new DateTime(2021, 6, 28, 3, 55, 25, 689, DateTimeKind.Local).AddTicks(3698));
        }
    }
}
