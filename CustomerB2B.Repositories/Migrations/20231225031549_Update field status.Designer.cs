﻿// <auto-generated />
using System;
using CustomerB2B.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerB2B.Repositories.Migrations
{
    [DbContext(typeof(CustomerB2BDbContext))]
    [Migration("20231225031549_Update field status")]
    partial class Updatefieldstatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CustomerB2B.Repositories.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DistrictId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanyAdditionalInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountBank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DaysOwed")
                        .HasColumnType("int");

                    b.Property<decimal?>("DebtLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Founding")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Revenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StaffSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CompanyAdditionalInformations");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanyCopperationInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CooperationField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CooperationOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoordinatingAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FrequenceUse")
                        .HasColumnType("int");

                    b.Property<bool?>("MOU")
                        .HasColumnType("bit");

                    b.Property<int?>("MouDuration")
                        .HasColumnType("int");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CompanyCopperationInformations");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanyDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CompanyDocuments");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanyGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CompanyGroups");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanyRepresentative", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CompanyRepresentatives");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanySpecificInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanySpecificInformations");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanySystemInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("CustomerType")
                        .HasColumnType("smallint");

                    b.Property<string>("SaleStaff")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanySystemInformations");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanyType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CompanyTypes");
                });

            modelBuilder.Entity("CustomerB2B.Repositories.CompanyTypeCompany", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyTypeCompany");
                });
#pragma warning restore 612, 618
        }
    }
}
