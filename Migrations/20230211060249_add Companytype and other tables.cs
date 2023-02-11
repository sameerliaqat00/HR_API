using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRAPI.Migrations
{
    /// <inheritdoc />
    public partial class addCompanytypeandothertables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanEligibleMonth",
                table: "CompanyProfiles");

            migrationBuilder.RenameColumn(
                name: "CompanyTypeID",
                table: "CompanyProfiles",
                newName: "CompanyTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "RegularizedPeriodID",
                table: "CompanyProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CompanyProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "CompanyProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AmountPrecision",
                table: "CompanyProfiles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AllowedEmployee",
                table: "CompanyProfiles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LoanEligibleMonthId",
                table: "CompanyProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.CompanyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LoanEligibleMonths",
                columns: table => new
                {
                    LoanEligibleMonthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanEligibleMonths = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanEligibleMonths", x => x.LoanEligibleMonthId);
                });

            migrationBuilder.CreateTable(
                name: "RegularizedPeriods",
                columns: table => new
                {
                    RegularizedPeriodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegularizedPeriods = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularizedPeriods", x => x.RegularizedPeriodId);
                });

            migrationBuilder.CreateTable(
                name: "SalaryMethods",
                columns: table => new
                {
                    SalayMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalayMethod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryMethods", x => x.SalayMethodId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProfiles_CompanyTypeId",
                table: "CompanyProfiles",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProfiles_LoanEligibleMonthId",
                table: "CompanyProfiles",
                column: "LoanEligibleMonthId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProfiles_RegularizedPeriodID",
                table: "CompanyProfiles",
                column: "RegularizedPeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProfiles_SalaryMethodID",
                table: "CompanyProfiles",
                column: "SalaryMethodID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyProfiles_CompanyTypes_CompanyTypeId",
                table: "CompanyProfiles",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "CompanyTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyProfiles_LoanEligibleMonths_LoanEligibleMonthId",
                table: "CompanyProfiles",
                column: "LoanEligibleMonthId",
                principalTable: "LoanEligibleMonths",
                principalColumn: "LoanEligibleMonthId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyProfiles_RegularizedPeriods_RegularizedPeriodID",
                table: "CompanyProfiles",
                column: "RegularizedPeriodID",
                principalTable: "RegularizedPeriods",
                principalColumn: "RegularizedPeriodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyProfiles_SalaryMethods_SalaryMethodID",
                table: "CompanyProfiles",
                column: "SalaryMethodID",
                principalTable: "SalaryMethods",
                principalColumn: "SalayMethodId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyProfiles_CompanyTypes_CompanyTypeId",
                table: "CompanyProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyProfiles_LoanEligibleMonths_LoanEligibleMonthId",
                table: "CompanyProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyProfiles_RegularizedPeriods_RegularizedPeriodID",
                table: "CompanyProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyProfiles_SalaryMethods_SalaryMethodID",
                table: "CompanyProfiles");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "LoanEligibleMonths");

            migrationBuilder.DropTable(
                name: "RegularizedPeriods");

            migrationBuilder.DropTable(
                name: "SalaryMethods");

            migrationBuilder.DropIndex(
                name: "IX_CompanyProfiles_CompanyTypeId",
                table: "CompanyProfiles");

            migrationBuilder.DropIndex(
                name: "IX_CompanyProfiles_LoanEligibleMonthId",
                table: "CompanyProfiles");

            migrationBuilder.DropIndex(
                name: "IX_CompanyProfiles_RegularizedPeriodID",
                table: "CompanyProfiles");

            migrationBuilder.DropIndex(
                name: "IX_CompanyProfiles_SalaryMethodID",
                table: "CompanyProfiles");

            migrationBuilder.DropColumn(
                name: "LoanEligibleMonthId",
                table: "CompanyProfiles");

            migrationBuilder.RenameColumn(
                name: "CompanyTypeId",
                table: "CompanyProfiles",
                newName: "CompanyTypeID");

            migrationBuilder.AlterColumn<int>(
                name: "RegularizedPeriodID",
                table: "CompanyProfiles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CompanyProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "CompanyProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AmountPrecision",
                table: "CompanyProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AllowedEmployee",
                table: "CompanyProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanEligibleMonth",
                table: "CompanyProfiles",
                type: "int",
                nullable: true);
        }
    }
}
