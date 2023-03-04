﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCoreLecture.Model;

#nullable disable

namespace WebApiCoreLecture.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiCoreLecture.Model.HRModel.EmployeeModel.TblEmployeeBasicInfo", b =>
                {
                    b.Property<long>("IntEmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IntEmployeeId"));

                    b.Property<long?>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ActionBy")
                        .HasColumnType("bigint");

                    b.Property<string>("AlternativeContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("BasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("BloodGroupId")
                        .HasColumnType("bigint");

                    b.Property<long?>("BusinessunitId")
                        .HasColumnType("bigint");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CostCenterId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CountryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DepartmentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DesignationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("EmpGradeId")
                        .HasColumnType("bigint");

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmployeeFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("EmploymentStatusId")
                        .HasColumnType("bigint");

                    b.Property<long?>("EmploymentTypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("GrossSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Idnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("IdtypeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LineManagerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LineManagerId")
                        .HasColumnType("bigint");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PositionId")
                        .HasColumnType("bigint");

                    b.Property<string>("PresentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Sbuid")
                        .HasColumnType("bigint");

                    b.Property<long?>("SupervisorId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserGroupId")
                        .HasColumnType("bigint");

                    b.Property<long?>("WorkplaceGroupId")
                        .HasColumnType("bigint");

                    b.Property<long?>("WorkplaceId")
                        .HasColumnType("bigint");

                    b.Property<string>("strEmployeeCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IntEmployeeId");

                    b.ToTable("TblEmployeeBasicInfos");
                });

            modelBuilder.Entity("WebApiCoreLecture.Model.TblDesignation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("TblDesignation");
                });

            modelBuilder.Entity("WebApiCoreLecture.Model.TblEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DesignationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Doj")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<int>("IsMarried")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("TblEmployee");
                });
#pragma warning restore 612, 618
        }
    }
}