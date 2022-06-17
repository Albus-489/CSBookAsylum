using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class collectionsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2aa0c6a-c1d0-4bfd-ae1a-70b84b84f9b9");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4ceffd56-f529-48a0-80ff-69026e38a324");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4e637c24-9173-4651-bf26-5f06c226befb");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "82dadbcf-7766-41fd-99f9-b576c6d962b8");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c365c010-e1b2-49dc-a3bd-a26271793b36");

            migrationBuilder.AlterColumn<string>(
                name: "text",
                table: "Comments",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collections_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookToCollection",
                columns: table => new
                {
                    booksId = table.Column<int>(type: "int", nullable: false),
                    collectionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookToCollection", x => new { x.booksId, x.collectionsId });
                    table.ForeignKey(
                        name: "FK_BookToCollection_Books_booksId",
                        column: x => x.booksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookToCollection_Collections_collectionsId",
                        column: x => x.collectionsId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BookToCollection_collectionsId",
                table: "BookToCollection",
                column: "collectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_userID",
                table: "Collections",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookToCollection");

            migrationBuilder.DropTable(
                name: "Collections");

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

            migrationBuilder.AlterColumn<string>(
                name: "text",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "c2aa0c6a-c1d0-4bfd-ae1a-70b84b84f9b9", 0, "72278efc-c1ac-461f-8c51-b500fe100b24", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "ad765b22-a55a-4468-83a2-f8fd5acb3fb8", false, "superadmin", 25 });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "birth", "death" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 21, 16, 389, DateTimeKind.Local).AddTicks(829), new DateTime(2022, 6, 13, 19, 21, 16, 389, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ceffd56-f529-48a0-80ff-69026e38a324", "1372c453-4bd9-4313-82f3-ef67ea76c640", "SuperAdmin", null },
                    { "4e637c24-9173-4651-bf26-5f06c226befb", "88e2819d-0e8b-4cc9-8a23-0da8e31477a0", "Basic", null },
                    { "82dadbcf-7766-41fd-99f9-b576c6d962b8", "de3e1953-a4f9-4525-a376-3cff46e9c697", "Admin", null },
                    { "c365c010-e1b2-49dc-a3bd-a26271793b36", "0a9758ab-2770-40ce-9ea7-ea24231288ed", "Moderator", null }
                });
        }
    }
}
