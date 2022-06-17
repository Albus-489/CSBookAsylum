using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class tokens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8129b8a4-94c0-42d4-b525-a4ac71c56d53");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "234453c7-a408-4882-a70c-7534aaf75e25");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8905f736-7feb-4ddc-a800-9c19de52e0bc");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b103d791-7421-4ac2-95bc-451b85c3717e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "cb84650f-b428-4a60-90e2-3752111d680f");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "5c7b5fd7-b969-4170-bf24-d959d12e734f", 0, "56d4dea7-352a-4dad-bcea-f5964f484ff0", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "5b1f24f6-7345-43ad-ac9c-37de503ff2e0", false, "superadmin", 25 });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "birth", "death" },
                values: new object[] { new DateTime(2022, 6, 14, 0, 39, 25, 560, DateTimeKind.Local).AddTicks(2486), new DateTime(2022, 6, 14, 0, 39, 25, 560, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fb61bd0-c4db-473e-83b4-ca6e406a8a8e", "b0e74734-3327-4267-bde6-fc852805d634", "Moderator", null },
                    { "3f2dfd87-4f22-48a4-a22e-e41ee324b6d6", "6d289a3d-1fc9-4add-ba19-77992bf0bd60", "Basic", null },
                    { "b8de88ef-61fa-4c04-bf93-a7a3f85d8d4c", "650ee5c9-94ce-4030-84a3-8b8508b427b2", "Admin", null },
                    { "d4621b59-3b2d-491a-abbf-bf1a00806aaf", "2484a068-189b-4e74-acb9-5c950d99de3c", "SuperAdmin", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UsersId",
                table: "RefreshToken",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c7b5fd7-b969-4170-bf24-d959d12e734f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "2fb61bd0-c4db-473e-83b4-ca6e406a8a8e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3f2dfd87-4f22-48a4-a22e-e41ee324b6d6");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b8de88ef-61fa-4c04-bf93-a7a3f85d8d4c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d4621b59-3b2d-491a-abbf-bf1a00806aaf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "8129b8a4-94c0-42d4-b525-a4ac71c56d53", 0, "0e1c486d-8719-497f-9087-b6ca2e621d7e", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "dbff8df9-9eb9-4439-becb-b0fb2c2962df", false, "superadmin", 25 });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "birth", "death" },
                values: new object[] { new DateTime(2022, 6, 13, 21, 14, 1, 327, DateTimeKind.Local).AddTicks(609), new DateTime(2022, 6, 13, 21, 14, 1, 327, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "234453c7-a408-4882-a70c-7534aaf75e25", "f6151499-4742-4b67-b226-4361bbddfc4b", "Basic", null },
                    { "8905f736-7feb-4ddc-a800-9c19de52e0bc", "b3a36d50-218b-48ba-b4f5-ec03e36cd267", "Moderator", null },
                    { "b103d791-7421-4ac2-95bc-451b85c3717e", "3ef0f4f6-3bb3-444d-97e5-630b977a9ee7", "SuperAdmin", null },
                    { "cb84650f-b428-4a60-90e2-3752111d680f", "4dc013d6-ada8-4315-85f8-0a90c2183be3", "Admin", null }
                });
        }
    }
}
