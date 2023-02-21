using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAssetTypeTableWithUserCompanyAndBranch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "WorkLocations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyProfileCompanyId",
                table: "WorkLocations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "SubDepartments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyProfileCompanyId",
                table: "SubDepartments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Designations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyProfileCompanyId",
                table: "Designations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "AssetTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AssetTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AssetTypes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AssetTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "AssetTypes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssetTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_WorkLocations_BranchId",
                table: "WorkLocations",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLocations_CompanyProfileCompanyId",
                table: "WorkLocations",
                column: "CompanyProfileCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDepartments_BranchId",
                table: "SubDepartments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDepartments_CompanyProfileCompanyId",
                table: "SubDepartments",
                column: "CompanyProfileCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_BranchId",
                table: "Designations",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_CompanyProfileCompanyId",
                table: "Designations",
                column: "CompanyProfileCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_BranchId",
                table: "Departments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyId",
                table: "Departments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_BranchId",
                table: "AssetTypes",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_CompanyId",
                table: "AssetTypes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_CreatedBy",
                table: "AssetTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_UpdatedBy",
                table: "AssetTypes",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypes_AspNetUser_CreatedBy",
                table: "AssetTypes",
                column: "CreatedBy",
                principalTable: "AspNetUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypes_AspNetUser_UpdatedBy",
                table: "AssetTypes",
                column: "UpdatedBy",
                principalTable: "AspNetUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypes_Branches_BranchId",
                table: "AssetTypes",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypes_CompanyProfiles_CompanyId",
                table: "AssetTypes",
                column: "CompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Branches_BranchId",
                table: "Departments",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_CompanyProfiles_CompanyId",
                table: "Departments",
                column: "CompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypes_AspNetUser_CreatedBy",
                table: "AssetTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypes_AspNetUser_UpdatedBy",
                table: "AssetTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypes_Branches_BranchId",
                table: "AssetTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypes_CompanyProfiles_CompanyId",
                table: "AssetTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Branches_BranchId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_CompanyProfiles_CompanyId",
                table: "Departments");

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
                name: "IX_WorkLocations_BranchId",
                table: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_WorkLocations_CompanyProfileCompanyId",
                table: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_SubDepartments_BranchId",
                table: "SubDepartments");

            migrationBuilder.DropIndex(
                name: "IX_SubDepartments_CompanyProfileCompanyId",
                table: "SubDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Designations_BranchId",
                table: "Designations");

            migrationBuilder.DropIndex(
                name: "IX_Designations_CompanyProfileCompanyId",
                table: "Designations");

            migrationBuilder.DropIndex(
                name: "IX_Departments_BranchId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CompanyId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypes_BranchId",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypes_CompanyId",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypes_CreatedBy",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypes_UpdatedBy",
                table: "AssetTypes");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "WorkLocations");

            migrationBuilder.DropColumn(
                name: "CompanyProfileCompanyId",
                table: "WorkLocations");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "SubDepartments");

            migrationBuilder.DropColumn(
                name: "CompanyProfileCompanyId",
                table: "SubDepartments");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CompanyProfileCompanyId",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "AssetTypes");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AssetTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AssetTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AssetTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "AssetTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AssetTypes");
        }
    }
}
