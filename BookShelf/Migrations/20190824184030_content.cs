using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class content : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_AspNetUsers_ApplicationUserId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_OwnerId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_OwnerId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Authors_ApplicationUserId",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Authors",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f0d3d848-34f4-424e-8f7c-7519fdb0f3a9", 0, "c994bf28-2990-4b15-bf82-3694dc9218f3", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFy7S9PgrrekQFI5hz5YKs3fFbeMFzw9zPzZEQaYxYa/QZljdBNlw7QNmTUreM6Ugw==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" },
                    { "4101bce7-1935-4fdd-9cdd-853ad8a33c27", 0, "35b26b12-c27f-4483-96eb-a76ea674d4fa", "shelley@me.com", true, "shelley", "arnold", false, null, "SHELLEY@ME.COM", "SHELLEY@ME.COM", "AQAAAAEAACcQAAAAEE4HBSRIxSC/prgy4j5sqhzW6C0ZrHYdfkGIqMC2OG9zrYmJpnXDfskl8Kv1rh02/Q==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "shelley@me.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "ApplicationUserId", "FirstName", "LastName", "Penname", "PreferredGenre" },
                values: new object[,]
                {
                    { 1, "00000000-ffff-ffff-ffff-ffffffffffff", "Cavy", "Arnold", "Woofie", "Food" },
                    { 2, "00000000-tttt-ffff-ffff-ffffffffffff", "Cerin", "Dog", "Dark", "Balls" },
                    { 3, "00000000-ffff-ffff-ffff-ffffffffffff", "Scout", "Arant", null, "Family" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Genre", "ISBN", "OwnerId", "PublishDate", "Title" },
                values: new object[] { 1, 1, "Food", 2375290724.0, "00000000-tttt-ffff-ffff-ffffffffffff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Getting More Treats" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Genre", "ISBN", "OwnerId", "PublishDate", "Title" },
                values: new object[] { 2, 2, "Games", 9852173896.0, "00000000-tttt-ffff-ffff-ffffffffffff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cathing the Ball" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4101bce7-1935-4fdd-9cdd-853ad8a33c27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0d3d848-34f4-424e-8f7c-7519fdb0f3a9");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Authors",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_OwnerId",
                table: "Books",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_ApplicationUserId",
                table: "Authors",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_AspNetUsers_ApplicationUserId",
                table: "Authors",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_OwnerId",
                table: "Books",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
