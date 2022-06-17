using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class authors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b36b9c82-47c4-4a38-8962-074155ec3f8c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "7612c384-b21b-4949-808d-3b77436f4fcc");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "79c43644-7c60-4c1c-b2bc-6a6dacbe4e68");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "bf3dd2d5-523a-4b21-aff9-8e38ca09615f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "cac91785-3b2c-4e27-85bf-6223c38cf35b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "fe6c5759-d3ac-4500-b792-6238b9857698", 0, "34958d11-b671-485b-9b37-fa75586fcb58", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "ba45603b-9672-44ab-a5bc-00e85698e1e8", false, "superadmin", 10 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "bio", "birth", "death", "name", "rating" },
                values: new object[] { 1, "Some 1st bio", new DateTime(2022, 6, 13, 17, 24, 1, 767, DateTimeKind.Local).AddTicks(1633), new DateTime(2022, 6, 13, 17, 24, 1, 767, DateTimeKind.Local).AddTicks(1673), "Name 1", 100 });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "41cd627b-f4ac-47e5-82ad-670fb623acc9", "e7608874-fc41-4e3f-bf89-f1a75b4fafc2", "Basic", null },
                    { "75f6725c-cc18-4424-9e49-b78f5571fbe4", "c71c0041-5ce9-4f1c-8c18-aa826069057d", "Admin", null },
                    { "8b56abe4-64b9-4bde-9a39-f51692173052", "e0f804fc-7e9a-48f3-bc5a-e40343b787cc", "SuperAdmin", null },
                    { "a5924432-8cd3-479e-ab04-2a5184575cc2", "0b09b42c-898a-4ff5-93d0-fbf2391e5053", "Moderator", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6c5759-d3ac-4500-b792-6238b9857698");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "41cd627b-f4ac-47e5-82ad-670fb623acc9");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "75f6725c-cc18-4424-9e49-b78f5571fbe4");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8b56abe4-64b9-4bde-9a39-f51692173052");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a5924432-8cd3-479e-ab04-2a5184575cc2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "b36b9c82-47c4-4a38-8962-074155ec3f8c", 0, "aec0ee6c-6636-485b-8854-849312a537c8", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "abed8ea3-09c3-4d63-a76d-cfc618a9e780", false, "superadmin", 10 });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7612c384-b21b-4949-808d-3b77436f4fcc", "9b6ae51c-f592-437d-bdaa-2fa28019e500", "SuperAdmin", null },
                    { "79c43644-7c60-4c1c-b2bc-6a6dacbe4e68", "2a8e719f-84e4-475e-9d6a-02e77b446a69", "Basic", null },
                    { "bf3dd2d5-523a-4b21-aff9-8e38ca09615f", "ac841b31-74e7-4bab-a7d3-15e947bbd95f", "Moderator", null },
                    { "cac91785-3b2c-4e27-85bf-6223c38cf35b", "d7d42f3e-1031-43f2-9636-4dab684ea1b5", "Admin", null }
                });
        }
    }
}
