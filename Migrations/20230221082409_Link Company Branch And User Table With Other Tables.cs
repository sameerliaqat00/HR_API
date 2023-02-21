using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRAPI.Migrations
{
    /// <inheritdoc />
    public partial class LinkCompanyBranchAndUserTableWithOtherTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Designations_Branches_BranchId",
                table: "Designations");

            migrationBuilder.DropForeignKey(
                name: "FK_Designations_CompanyProfiles_CompanyProfileCompanyId",
                table: "Designations");

            migrationBuilder.DropForeignKey(
                name: "FK_SubDepartments_Branches_BranchId",
                table: "SubDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_SubDepartments_CompanyProfiles_CompanyProfileCompanyId",
                table: "SubDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLocations_Branches_BranchId",
                table: "WorkLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLocations_CompanyProfiles_CompanyProfileCompanyId",
                table: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_WorkLocations_CompanyProfileCompanyId",
                table: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_SubDepartments_CompanyProfileCompanyId",
                table: "SubDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Designations_CompanyProfileCompanyId",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CompanyProfileCompanyId",
                table: "WorkLocations");

            migrationBuilder.DropColumn(
                name: "CompanyProfileCompanyId",
                table: "SubDepartments");

            migrationBuilder.DropColumn(
                name: "CompanyProfileCompanyId",
                table: "Designations");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "WorkLocations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "WorkLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "WorkLocations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkLocations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "WorkLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "SubDepartments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "SubDepartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SubDepartments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SubDepartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "SubDepartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Designations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Designations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Designations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Designations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Designations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLocations_CompanyId",
                table: "WorkLocations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLocations_CreatedBy",
                table: "WorkLocations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SubDepartments_CompanyId",
                table: "SubDepartments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDepartments_CreatedBy",
                table: "SubDepartments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_CompanyId",
                table: "Designations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_CreatedBy",
                table: "Designations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CreatedBy",
                table: "Departments",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_AspNetUser_CreatedBy",
                table: "Departments",
                column: "CreatedBy",
                principalTable: "AspNetUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Designations_AspNetUser_CreatedBy",
                table: "Designations",
                column: "CreatedBy",
                principalTable: "AspNetUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Designations_Branches_BranchId",
                table: "Designations",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Designations_CompanyProfiles_CompanyId",
                table: "Designations",
                column: "CompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubDepartments_AspNetUser_CreatedBy",
                table: "SubDepartments",
                column: "CreatedBy",
                principalTable: "AspNetUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SubDepartments_Branches_BranchId",
                table: "SubDepartments",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SubDepartments_CompanyProfiles_CompanyId",
                table: "SubDepartments",
                column: "CompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLocations_AspNetUser_CreatedBy",
                table: "WorkLocations",
                column: "CreatedBy",
                principalTable: "AspNetUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLocations_Branches_BranchId",
                table: "WorkLocations",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLocations_CompanyProfiles_CompanyId",
                table: "WorkLocations",
                column: "CompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUser_CreatedBy",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Designations_AspNetUser_CreatedBy",
                table: "Designations");

            migrationBuilder.DropForeignKey(
                name: "FK_Designations_Branches_BranchId",
                table: "Designations");

            migrationBuilder.DropForeignKey(
                name: "FK_Designations_CompanyProfiles_CompanyId",
                table: "Designations");

            migrationBuilder.DropForeignKey(
                name: "FK_SubDepartments_AspNetUser_CreatedBy",
                table: "SubDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_SubDepartments_Branches_BranchId",
                table: "SubDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_SubDepartments_CompanyProfiles_CompanyId",
                table: "SubDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLocations_AspNetUser_CreatedBy",
                table: "WorkLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLocations_Branches_BranchId",
                table: "WorkLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLocations_CompanyProfiles_CompanyId",
                table: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_WorkLocations_CompanyId",
                table: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_WorkLocations_CreatedBy",
                table: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_SubDepartments_CompanyId",
                table: "SubDepartments");

            migrationBuilder.DropIndex(
                name: "IX_SubDepartments_CreatedBy",
                table: "SubDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Designations_CompanyId",
                table: "Designations");

            migrationBuilder.DropIndex(
                name: "IX_Designations_CreatedBy",
                table: "Designations");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CreatedBy",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "WorkLocations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkLocations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "WorkLocations");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "WorkLocations");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "SubDepartments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SubDepartments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SubDepartments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SubDepartments");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "WorkLocations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyProfileCompanyId",
                table: "WorkLocations",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "SubDepartments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyProfileCompanyId",
                table: "SubDepartments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Designations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyProfileCompanyId",
                table: "Designations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkLocations_CompanyProfileCompanyId",
                table: "WorkLocations",
                column: "CompanyProfileCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDepartments_CompanyProfileCompanyId",
                table: "SubDepartments",
                column: "CompanyProfileCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_CompanyProfileCompanyId",
                table: "Designations",
                column: "CompanyProfileCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Designations_Branches_BranchId",
                table: "Designations",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Designations_CompanyProfiles_CompanyProfileCompanyId",
                table: "Designations",
                column: "CompanyProfileCompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubDepartments_Branches_BranchId",
                table: "SubDepartments",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubDepartments_CompanyProfiles_CompanyProfileCompanyId",
                table: "SubDepartments",
                column: "CompanyProfileCompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLocations_Branches_BranchId",
                table: "WorkLocations",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLocations_CompanyProfiles_CompanyProfileCompanyId",
                table: "WorkLocations",
                column: "CompanyProfileCompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "CompanyId");
        }
    }
}
