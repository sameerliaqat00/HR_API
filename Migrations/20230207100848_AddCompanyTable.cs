using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyProfiles",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTypeID = table.Column<int>(type: "int", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowEmployeeLifeCycle = table.Column<bool>(type: "bit", nullable: true),
                    IsCnicMandatory = table.Column<bool>(type: "bit", nullable: true),
                    SalaryMethodID = table.Column<int>(type: "int", nullable: true),
                    AllowedEmployee = table.Column<int>(type: "int", nullable: true),
                    AccountExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanEligibleMonth = table.Column<int>(type: "int", nullable: true),
                    AmountPrecision = table.Column<int>(type: "int", nullable: true),
                    IsMinMaxTime = table.Column<bool>(type: "bit", nullable: false),
                    TotalWorkingDays = table.Column<int>(type: "int", nullable: true),
                    MonthDays = table.Column<int>(type: "int", nullable: true),
                    GraduityCalculateType = table.Column<bool>(type: "bit", nullable: true),
                    RaisedBeforeDays = table.Column<int>(type: "int", nullable: true),
                    DaysInPeriod = table.Column<int>(type: "int", nullable: true),
                    RegularizedPeriodID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProfiles", x => x.CompanyId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyProfiles");
        }
    }
}
