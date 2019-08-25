using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class int64 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "f1dc650e-a6a5-41c1-8fb3-5c407775a6f9", 0, "79486424-8113-43aa-bdc2-087afc64f61c", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEL+GAAkjjKPpWkWYpc7SQGbeth8sP3dWZv6WMY4k1vZyMT6yfIcfiUPEQnTzyEs53Q==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d21c0f74-1294-4b1b-a605-4ed5c9203de8", 0, "4a0bb87c-a505-4f44-9b98-1a317a683ca8", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEGEavh4+ib3O7vCtPuvvjuF1EAETcU09i7uhfV9ze7/lR8z/+qOM3guC4rR+cATVAg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ISBN",
                value: 7654329876L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d21c0f74-1294-4b1b-a605-4ed5c9203de8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1dc650e-a6a5-41c1-8fb3-5c407775a6f9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "be360bd5-0bbe-40f4-bbdc-c7e54a98bd59", 0, "e7ec0c20-0a7e-440e-8d3d-85eb2e096967", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFHPXCVbLo3U3nNm2U/VMWd/ooThSm/rLynS05+pS45ASskjXIU0FQ6s9elDjd3DPw==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9a6675b0-6331-4f95-be7c-6930df95d8ef", 0, "ef8c9ed8-bb2b-4133-bf97-4459d4b10f41", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEDcq0VuOjbvos+NveP+raO2xoKSPXfhoXnTZSXmfZQojsh0Fx2NEqBcKrpbJY8Rvyg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ISBN",
                value: 9852173896L);
        }
    }
}
