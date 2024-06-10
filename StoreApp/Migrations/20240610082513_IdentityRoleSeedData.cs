using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0470f42b-f7ea-4994-af34-6dc651d04156", "6e0b0ad1-57b1-4c39-824e-e8e250ac40cd", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d4074e4-6350-4ed5-b30a-7a793ebdfa9a", "a12dddfb-b8ef-4d6b-abb0-cd3742407421", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "767125aa-aaab-41b0-9e48-838706bf2763", "ef195e7c-4505-43c1-98ae-e606bfcc70ba", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0470f42b-f7ea-4994-af34-6dc651d04156");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d4074e4-6350-4ed5-b30a-7a793ebdfa9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "767125aa-aaab-41b0-9e48-838706bf2763");
        }
    }
}
