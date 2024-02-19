using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class PostgresImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d520932-c1df-401a-952b-07f35f07de86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf5d0e98-2833-46fd-93a6-d008c1c40e95");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e6525f2-ee03-4a1c-9d29-dfe75619def4", null, "Member", "MEMBER" },
                    { "840ca184-604d-478f-a43d-6bd9802118e5", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e6525f2-ee03-4a1c-9d29-dfe75619def4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "840ca184-604d-478f-a43d-6bd9802118e5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d520932-c1df-401a-952b-07f35f07de86", null, "Admin", "ADMIN" },
                    { "cf5d0e98-2833-46fd-93a6-d008c1c40e95", null, "Member", "MEMBER" }
                });
        }
    }
}
