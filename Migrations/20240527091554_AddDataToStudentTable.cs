using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIPracticeProject.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "AdmissionDate", "Age", "Name" },
                values: new object[] { 1, "adrds--", new DateTime(2024, 5, 27, 14, 45, 53, 545, DateTimeKind.Local).AddTicks(7175), 25, "DummyData" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
