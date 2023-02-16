using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSalaryMethodColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SalayMethod",
                table: "SalaryMethods",
                newName: "SalaryMethods");

            migrationBuilder.RenameColumn(
                name: "SalayMethodId",
                table: "SalaryMethods",
                newName: "SalaryMethodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SalaryMethods",
                table: "SalaryMethods",
                newName: "SalayMethod");

            migrationBuilder.RenameColumn(
                name: "SalaryMethodId",
                table: "SalaryMethods",
                newName: "SalayMethodId");
        }
    }
}
