﻿// <auto-generated />
using System;
using HR_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230220120157_Add Company Branch And User")]
    partial class AddCompanyBranchAndUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HR_API.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("HR_API.Models.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AspNetUser");
                });

            modelBuilder.Entity("HR_API.Models.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssetId"));

                    b.Property<int?>("AssetsTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BranchId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuaranteeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerialNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AssetId");

                    b.HasIndex("AssetsTypeId");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("StatusId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("HR_API.Models.AssetType", b =>
                {
                    b.Property<int>("AssetTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssetTypeId"));

                    b.Property<string>("AssetTypes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssetTypeId");

                    b.ToTable("AssetTypes");
                });

            modelBuilder.Entity("HR_API.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.HasKey("BranchId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("HR_API.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("HR_API.Models.CompanyProfile", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<DateTime>("AccountExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("AllowEmployeeLifeCycle")
                        .HasColumnType("bit");

                    b.Property<int?>("AllowedEmployee")
                        .HasColumnType("int");

                    b.Property<int?>("AmountPrecision")
                        .HasColumnType("int");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyTypeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("DaysInPeriod")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GraduityCalculateType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsCnicMandatory")
                        .HasColumnType("bit");

                    b.Property<string>("IsMinMaxTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoanEligibleMonthId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("MonthDays")
                        .HasColumnType("int");

                    b.Property<int?>("RaisedBeforeDays")
                        .HasColumnType("int");

                    b.Property<int?>("RegularizedPeriodID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SalaryMethodID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("TotalWorkingDays")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.HasIndex("CompanyTypeId");

                    b.HasIndex("LoanEligibleMonthId");

                    b.HasIndex("RegularizedPeriodID");

                    b.HasIndex("SalaryMethodID");

                    b.ToTable("CompanyProfiles");
                });

            modelBuilder.Entity("HR_API.Models.CompanyType", b =>
                {
                    b.Property<int>("CompanyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyTypeId"));

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyTypeId");

                    b.ToTable("CompanyTypes");
                });

            modelBuilder.Entity("HR_API.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("HR_API.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Departments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HR_API.Models.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignationId"));

                    b.Property<string>("Designations")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesignationId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("HR_API.Models.EmployeeGrade", b =>
                {
                    b.Property<int>("EmployeeGradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeGradeId"));

                    b.Property<string>("GradeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GradeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeGradeId");

                    b.ToTable("EmployeeGrades");
                });

            modelBuilder.Entity("HR_API.Models.LoanEligibleMonth", b =>
                {
                    b.Property<int>("LoanEligibleMonthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanEligibleMonthId"));

                    b.Property<string>("LoanEligibleMonths")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoanEligibleMonthId");

                    b.ToTable("LoanEligibleMonths");
                });

            modelBuilder.Entity("HR_API.Models.RegularizedPeriod", b =>
                {
                    b.Property<int>("RegularizedPeriodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegularizedPeriodId"));

                    b.Property<string>("RegularizedPeriods")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegularizedPeriodId");

                    b.ToTable("RegularizedPeriods");
                });

            modelBuilder.Entity("HR_API.Models.SalaryMethod", b =>
                {
                    b.Property<int>("SalaryMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaryMethodId"));

                    b.Property<string>("SalaryMethods")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalaryMethodId");

                    b.ToTable("SalaryMethods");
                });

            modelBuilder.Entity("HR_API.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<string>("Statuss")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("HR_API.Models.SubDepartment", b =>
                {
                    b.Property<int>("SubDepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubDepartmentId"));

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("SubDepartments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubDepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("SubDepartments");
                });

            modelBuilder.Entity("HR_API.Models.WorkLocation", b =>
                {
                    b.Property<int>("WorkLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkLocationId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool?>("EnableGeoFence")
                        .HasColumnType("bit");

                    b.Property<bool?>("EnableGeoTagging")
                        .HasColumnType("bit");

                    b.Property<bool?>("FaceMode")
                        .HasColumnType("bit");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ManualMode")
                        .HasColumnType("bit");

                    b.Property<bool?>("QRCodeMode")
                        .HasColumnType("bit");

                    b.Property<double?>("Radius")
                        .HasColumnType("float");

                    b.Property<bool?>("VideoMode")
                        .HasColumnType("bit");

                    b.Property<bool?>("VoiceMode")
                        .HasColumnType("bit");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkLocationId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("WorkLocations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HR_API.Models.Asset", b =>
                {
                    b.HasOne("HR_API.Models.AssetType", "AssetType")
                        .WithMany("Asset")
                        .HasForeignKey("AssetsTypeId");

                    b.HasOne("HR_API.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_API.Models.CompanyProfile", "CompanyProfile")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("HR_API.Models.AspNetUser", "AspNetUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_API.Models.Status", "Status")
                        .WithMany("Asset")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_API.Models.AspNetUser", "AspNetUser1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUser");

                    b.Navigation("AspNetUser1");

                    b.Navigation("AssetType");

                    b.Navigation("Branch");

                    b.Navigation("CompanyProfile");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("HR_API.Models.Branch", b =>
                {
                    b.HasOne("HR_API.Models.CompanyProfile", "CompanyProfile")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("CompanyProfile");
                });

            modelBuilder.Entity("HR_API.Models.City", b =>
                {
                    b.HasOne("HR_API.Models.Country", "Country")
                        .WithMany("City")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HR_API.Models.CompanyProfile", b =>
                {
                    b.HasOne("HR_API.Models.CompanyType", "CompanyType")
                        .WithMany("CompanyProfile")
                        .HasForeignKey("CompanyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_API.Models.LoanEligibleMonth", "LoanEligibleMonth")
                        .WithMany("CompanyProfile")
                        .HasForeignKey("LoanEligibleMonthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_API.Models.RegularizedPeriod", "RegularizedPeriod")
                        .WithMany("CompanyProfile")
                        .HasForeignKey("RegularizedPeriodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_API.Models.SalaryMethod", "SalaryMethod")
                        .WithMany("CompanyProfile")
                        .HasForeignKey("SalaryMethodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyType");

                    b.Navigation("LoanEligibleMonth");

                    b.Navigation("RegularizedPeriod");

                    b.Navigation("SalaryMethod");
                });

            modelBuilder.Entity("HR_API.Models.SubDepartment", b =>
                {
                    b.HasOne("HR_API.Models.Department", "Department")
                        .WithMany("SubDepartment")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("HR_API.Models.WorkLocation", b =>
                {
                    b.HasOne("HR_API.Models.City", "City")
                        .WithMany("WorkLocation")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_API.Models.Country", "Country")
                        .WithMany("WorkLocation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HR_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HR_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HR_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR_API.Models.AssetType", b =>
                {
                    b.Navigation("Asset");
                });

            modelBuilder.Entity("HR_API.Models.City", b =>
                {
                    b.Navigation("WorkLocation");
                });

            modelBuilder.Entity("HR_API.Models.CompanyType", b =>
                {
                    b.Navigation("CompanyProfile");
                });

            modelBuilder.Entity("HR_API.Models.Country", b =>
                {
                    b.Navigation("City");

                    b.Navigation("WorkLocation");
                });

            modelBuilder.Entity("HR_API.Models.Department", b =>
                {
                    b.Navigation("SubDepartment");
                });

            modelBuilder.Entity("HR_API.Models.LoanEligibleMonth", b =>
                {
                    b.Navigation("CompanyProfile");
                });

            modelBuilder.Entity("HR_API.Models.RegularizedPeriod", b =>
                {
                    b.Navigation("CompanyProfile");
                });

            modelBuilder.Entity("HR_API.Models.SalaryMethod", b =>
                {
                    b.Navigation("CompanyProfile");
                });

            modelBuilder.Entity("HR_API.Models.Status", b =>
                {
                    b.Navigation("Asset");
                });
#pragma warning restore 612, 618
        }
    }
}
