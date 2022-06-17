using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class authorsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a93c614-59ad-4435-9370-53a7cac1f46d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "18e9a97c-357a-4e49-9d2a-710d3ea96b1e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3ec449ca-ea65-40ae-8a00-4922aa7d1217");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "894ae775-0b60-4842-b5d3-581e11eea2bd");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8cf5a471-8e1e-4e15-9fbb-b3a3c3d9eb04");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4a93c614-59ad-4435-9370-53a7cac1f46d", 0, "e8b9f5f6-a335-4faf-8fc3-41087d98af2e", "superadmin@gmail.com", true, "super", "admin", false, null, null, null, null, null, true, 0, "e76ed311-a2b8-40e3-9390-487cc9244517", false, "superadmin", 10 });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18e9a97c-357a-4e49-9d2a-710d3ea96b1e", "f0083c81-1a0a-4c19-8a83-2db8c8822dcf", "Admin", null },
                    { "3ec449ca-ea65-40ae-8a00-4922aa7d1217", "1e9bcc92-6bd4-4b5b-9069-eef3907ccd69", "Basic", null },
                    { "894ae775-0b60-4842-b5d3-581e11eea2bd", "741beeac-f0ef-4be3-b97d-2a2380807628", "Moderator", null },
                    { "8cf5a471-8e1e-4e15-9fbb-b3a3c3d9eb04", "171debd2-ecba-4467-9f08-6d3350a74d30", "SuperAdmin", null }
                });
        }
    }
}
