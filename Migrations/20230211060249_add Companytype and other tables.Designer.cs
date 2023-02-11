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
    [Migration("20230211060249_add Companytype and other tables")]
    partial class addCompanytypeandothertables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                    b.Property<int>("SalayMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalayMethodId"));

                    b.Property<string>("SalayMethod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalayMethodId");

                    b.ToTable("SalaryMethods");
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

            modelBuilder.Entity("HR_API.Models.CompanyType", b =>
                {
                    b.Navigation("CompanyProfile");
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
#pragma warning restore 612, 618
        }
    }
}