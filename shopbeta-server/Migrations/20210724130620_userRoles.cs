using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbeta.Migrations
{
    public partial class userRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

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
    }
}
