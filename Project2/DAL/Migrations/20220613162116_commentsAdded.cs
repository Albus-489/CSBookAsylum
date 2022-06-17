using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class commentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    bookID = table.Column<int>(type: "int", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Books_bookID",
                        column: x => x.bookID,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_bookID",
                table: "Comments",
                column: "bookID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_userID",
                table: "Comments",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

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
        }
    }
}
