using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class isbn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4101bce7-1935-4fdd-9cdd-853ad8a33c27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0d3d848-34f4-424e-8f7c-7519fdb0f3a9");

            migrationBuilder.AlterColumn<long>(
                name: "ISBN",
                table: "Books",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 13);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a5f77c63-9f9c-4724-9b5c-de0303c12346", 0, "61d22797-f922-4b36-8fb8-4babed1ccb46", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGsOac+OD0993GjMJ4m5hMVC+Bc3NPFFxxfLGXuiiD/N94x/2k1QAL+E0jAsT6BFsg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" },
                    { "b5b992bd-db7d-44dc-acfc-f47cc83125e6", 0, "dcd8e02e-b2f9-4232-a7c0-1a65a18c8ab7", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEEPUL3IzJLY5MoDQ3B7c5GPBM5HXCzrlsQYYJTuDGfCIQxW+Qp654EXJR6P5UGaTxA==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ISBN",
                value: 2375290724L);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ISBN",
                value: 9852173896L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5f77c63-9f9c-4724-9b5c-de0303c12346");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5b992bd-db7d-44dc-acfc-f47cc83125e6");

            migrationBuilder.AlterColumn<double>(
                name: "ISBN",
                table: "Books",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(long),
                oldMaxLength: 13);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f0d3d848-34f4-424e-8f7c-7519fdb0f3a9", 0, "c994bf28-2990-4b15-bf82-3694dc9218f3", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFy7S9PgrrekQFI5hz5YKs3fFbeMFzw9zPzZEQaYxYa/QZljdBNlw7QNmTUreM6Ugw==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" },
                    { "4101bce7-1935-4fdd-9cdd-853ad8a33c27", 0, "35b26b12-c27f-4483-96eb-a76ea674d4fa", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEE4HBSRIxSC/prgy4j5sqhzW6C0ZrHYdfkGIqMC2OG9zrYmJpnXDfskl8Kv1rh02/Q==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ISBN",
                value: 2375290724.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ISBN",
                value: 9852173896.0);
        }
    }
}
