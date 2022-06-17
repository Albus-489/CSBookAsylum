using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class autandbooksrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6c5759-d3ac-4500-b792-6238b9857698");

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

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "genre",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "authorId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "3792ff5d-e64a-41da-80b2-bd17fc7bebec", 0, "7362fc70-a73f-4325-b19e-314a73e5e9eb", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "d84246c2-0ba7-49e7-8731-34ffbb7e5480", false, "superadmin", 10 });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "birth", "death" },
                values: new object[] { new DateTime(2022, 6, 13, 17, 42, 46, 768, DateTimeKind.Local).AddTicks(3689), new DateTime(2022, 6, 13, 17, 42, 46, 768, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "269933d2-f417-4b63-9201-096e1599e16d", "097fca89-5722-4f6d-8be6-2df337baac4f", "Moderator", null },
                    { "4fb1338d-5eb4-4409-85e8-eb718e7560f5", "c24794f3-d8d5-41ac-ac6d-06cbf06d77bc", "SuperAdmin", null },
                    { "6852f794-ad60-46dd-8e39-9ee5c052451c", "69edd646-7279-4238-99ce-d1722755c3d1", "Admin", null },
                    { "ad75aa86-f0d2-4bc7-a7b9-ffc35f5468fa", "3b46a658-293e-44e1-8a4e-2d109ee0b36b", "Basic", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_authorId",
                table: "Books",
                column: "authorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_authorId",
                table: "Books",
                column: "authorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_authorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_authorId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3792ff5d-e64a-41da-80b2-bd17fc7bebec");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "269933d2-f417-4b63-9201-096e1599e16d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4fb1338d-5eb4-4409-85e8-eb718e7560f5");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6852f794-ad60-46dd-8e39-9ee5c052451c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ad75aa86-f0d2-4bc7-a7b9-ffc35f5468fa");

            migrationBuilder.DropColumn(
                name: "authorId",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "genre",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "fe6c5759-d3ac-4500-b792-6238b9857698", 0, "34958d11-b671-485b-9b37-fa75586fcb58", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "ba45603b-9672-44ab-a5bc-00e85698e1e8", false, "superadmin", 10 });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "birth", "death" },
                values: new object[] { new DateTime(2022, 6, 13, 17, 24, 1, 767, DateTimeKind.Local).AddTicks(1633), new DateTime(2022, 6, 13, 17, 24, 1, 767, DateTimeKind.Local).AddTicks(1673) });

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
    }
}
