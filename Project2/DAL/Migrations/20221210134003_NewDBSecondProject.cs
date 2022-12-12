using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class NewDBSecondProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    death = table.Column<DateTime>(type: "datetime2", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_author_id",
                        column: x => x.author_id,
                        principalTable: "Authors",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    book_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Books_book_id",
                        column: x => x.book_id,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "bio", "birth", "death", "name", "rating" },
                values: new object[] { 1, "Some 1st bio", new DateTime(2022, 12, 10, 15, 40, 3, 160, DateTimeKind.Local).AddTicks(5877), new DateTime(2022, 12, 10, 15, 40, 3, 160, DateTimeKind.Local).AddTicks(5912), "Name 1", 100 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "author_id", "created", "description", "genre", "image", "name", "rating" },
                values: new object[] { 1, null, null, "No info 1", "Preview genre 1", null, "Preview book 1", 2 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "author_id", "created", "description", "genre", "image", "name", "rating" },
                values: new object[] { 2, null, null, "No info 2", "Preview genre 2", null, "Preview book 2", 90 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_author_id",
                table: "Books",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_BookToCollection_collectionsId",
                table: "BookToCollection",
                column: "collectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_book_id",
                table: "Comments",
                column: "book_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookToCollection");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
