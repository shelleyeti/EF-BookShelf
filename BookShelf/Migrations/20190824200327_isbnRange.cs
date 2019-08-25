using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class isbnRange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5f77c63-9f9c-4724-9b5c-de0303c12346");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5b992bd-db7d-44dc-acfc-f47cc83125e6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "be360bd5-0bbe-40f4-bbdc-c7e54a98bd59", 0, "e7ec0c20-0a7e-440e-8d3d-85eb2e096967", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFHPXCVbLo3U3nNm2U/VMWd/ooThSm/rLynS05+pS45ASskjXIU0FQ6s9elDjd3DPw==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9a6675b0-6331-4f95-be7c-6930df95d8ef", 0, "ef8c9ed8-bb2b-4133-bf97-4459d4b10f41", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEDcq0VuOjbvos+NveP+raO2xoKSPXfhoXnTZSXmfZQojsh0Fx2NEqBcKrpbJY8Rvyg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a6675b0-6331-4f95-be7c-6930df95d8ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be360bd5-0bbe-40f4-bbdc-c7e54a98bd59");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a5f77c63-9f9c-4724-9b5c-de0303c12346", 0, "61d22797-f922-4b36-8fb8-4babed1ccb46", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGsOac+OD0993GjMJ4m5hMVC+Bc3NPFFxxfLGXuiiD/N94x/2k1QAL+E0jAsT6BFsg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b5b992bd-db7d-44dc-acfc-f47cc83125e6", 0, "dcd8e02e-b2f9-4232-a7c0-1a65a18c8ab7", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEEPUL3IzJLY5MoDQ3B7c5GPBM5HXCzrlsQYYJTuDGfCIQxW+Qp654EXJR6P5UGaTxA==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" });
        }
    }
}
