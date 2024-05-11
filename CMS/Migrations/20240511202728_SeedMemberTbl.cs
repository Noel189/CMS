using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class SeedMemberTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Membertbl",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "MemberSince", "Phone" },
                values: new object[,]
                {
                    { 1, "466 dummy address", "dummy@gmail.com", "John", "Bob", "11/05/2024", "555-888-666" },
                    { 2, "466 dummy address", "dummy2@gmail.com", "James", "Rob", "11/05/2024", "555-888-888" },
                    { 3, "466 dummy address", "dummy3@gmail.com", "Jacob", "Job", "11/05/2024", "555-888-777" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Membertbl",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Membertbl",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Membertbl",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
