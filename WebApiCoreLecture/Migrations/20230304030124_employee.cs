using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCoreLecture.Migrations
{
    /// <inheritdoc />
    public partial class employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblDesignation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDesignation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Doj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsMarried = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    DesignationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmployee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblEmployeeBasicInfos",
                columns: table => new
                {
                    IntEmployeeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strEmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessunitId = table.Column<long>(type: "bigint", nullable: true),
                    Sbuid = table.Column<long>(type: "bigint", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    DesignationId = table.Column<long>(type: "bigint", nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdtypeId = table.Column<long>(type: "bigint", nullable: true),
                    Idnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroupId = table.Column<long>(type: "bigint", nullable: true),
                    UserGroupId = table.Column<long>(type: "bigint", nullable: true),
                    SupervisorId = table.Column<long>(type: "bigint", nullable: true),
                    CostCenterId = table.Column<long>(type: "bigint", nullable: true),
                    WorkplaceGroupId = table.Column<long>(type: "bigint", nullable: true),
                    WorkplaceId = table.Column<long>(type: "bigint", nullable: true),
                    PositionId = table.Column<long>(type: "bigint", nullable: true),
                    EmpGradeId = table.Column<long>(type: "bigint", nullable: true),
                    EmploymentTypeId = table.Column<long>(type: "bigint", nullable: true),
                    LineManagerId = table.Column<long>(type: "bigint", nullable: true),
                    LineManagerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentStatusId = table.Column<long>(type: "bigint", nullable: true),
                    ActionBy = table.Column<long>(type: "bigint", nullable: true),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmployeeBasicInfos", x => x.IntEmployeeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblDesignation");

            migrationBuilder.DropTable(
                name: "TblEmployee");

            migrationBuilder.DropTable(
                name: "TblEmployeeBasicInfos");
        }
    }
}
