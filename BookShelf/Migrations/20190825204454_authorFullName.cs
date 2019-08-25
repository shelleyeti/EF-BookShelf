using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class authorFullName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d21c0f74-1294-4b1b-a605-4ed5c9203de8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1dc650e-a6a5-41c1-8fb3-5c407775a6f9");

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Books",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ceef6cb4-4c8d-4e8d-94a2-8a464b7155cb", 0, "f7f5dcdb-a750-4207-9942-53aa676a3b5c", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIJJPd6CQ+W36TL5jSPJDoafwpMZNnsIZqJEhYcp53XnokW4bkiig5fJoSBRXEe9qQ==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "52d12165-ed5f-46c3-a0d9-e5e96490ca8c", 0, "2de12aa8-a2cd-4290-ade8-4ed08bc247d5", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEKJBTxQskcCAZvlS6eM+d+D+/oBp3qeXkP+zW6KDZWS2ICYR19Wqu+nxjl0izEZt4g==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52d12165-ed5f-46c3-a0d9-e5e96490ca8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ceef6cb4-4c8d-4e8d-94a2-8a464b7155cb");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f1dc650e-a6a5-41c1-8fb3-5c407775a6f9", 0, "79486424-8113-43aa-bdc2-087afc64f61c", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEL+GAAkjjKPpWkWYpc7SQGbeth8sP3dWZv6WMY4k1vZyMT6yfIcfiUPEQnTzyEs53Q==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d21c0f74-1294-4b1b-a605-4ed5c9203de8", 0, "4a0bb87c-a505-4f44-9b98-1a317a683ca8", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEGEavh4+ib3O7vCtPuvvjuF1EAETcU09i7uhfV9ze7/lR8z/+qOM3guC4rR+cATVAg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" });
        }
    }
}
