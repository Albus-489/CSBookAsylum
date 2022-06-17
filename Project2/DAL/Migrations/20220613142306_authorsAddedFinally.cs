using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class authorsAddedFinally : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4423298d-7de6-4202-b4cd-43e861b1497d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1e5fa433-d5de-4e0f-9f82-c2d06933167e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "783748d0-40dc-45ca-8fd7-c16e7dd5fbca");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "7a0303de-d6ea-4eef-b949-c6b49ee12f4c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d76b51a0-ff67-46f0-bdcb-8fa381bdc5a5");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4423298d-7de6-4202-b4cd-43e861b1497d", 0, "e99673a9-0ef4-4e09-bfa8-ff84b8f39d6d", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "b5a00e21-e018-4731-81d8-2fbf18814255", false, "superadmin", 10 });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e5fa433-d5de-4e0f-9f82-c2d06933167e", "ce5557f8-0124-46d2-825d-34c2b422efd9", "SuperAdmin", null },
                    { "783748d0-40dc-45ca-8fd7-c16e7dd5fbca", "68628bf7-66dd-4528-9214-e8012519e7d2", "Admin", null },
                    { "7a0303de-d6ea-4eef-b949-c6b49ee12f4c", "17c40b2b-0062-4b86-80b6-2bb8a47e97b7", "Basic", null },
                    { "d76b51a0-ff67-46f0-bdcb-8fa381bdc5a5", "49a5bfea-28e6-4c54-8c26-5fa3c561f61c", "Moderator", null }
                });
        }
    }
}
