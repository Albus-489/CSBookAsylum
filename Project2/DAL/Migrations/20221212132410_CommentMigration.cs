using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class CommentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Books_book_id",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "book_id",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "birth", "death" },
                values: new object[] { new DateTime(2022, 12, 12, 15, 24, 10, 425, DateTimeKind.Local).AddTicks(2537), new DateTime(2022, 12, 12, 15, 24, 10, 425, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Books_book_id",
                table: "Comments",
                column: "book_id",
                principalTable: "Books",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Books_book_id",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "book_id",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "birth", "death" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 40, 3, 160, DateTimeKind.Local).AddTicks(5877), new DateTime(2022, 12, 10, 15, 40, 3, 160, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Books_book_id",
                table: "Comments",
                column: "book_id",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
