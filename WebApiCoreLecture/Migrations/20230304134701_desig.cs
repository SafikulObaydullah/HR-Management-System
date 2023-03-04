using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCoreLecture.Migrations
{
    /// <inheritdoc />
    public partial class desig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblCostCenter",
                columns: table => new
                {
                    IntCostCenterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrCostCenterCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrCostCenterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCostCenterTypeId = table.Column<long>(type: "bigint", nullable: false),
                    IntControllingUnitId = table.Column<long>(type: "bigint", nullable: false),
                    IntProfitCenterId = table.Column<long>(type: "bigint", nullable: false),
                    IntSbuid = table.Column<long>(type: "bigint", nullable: false),
                    IntCostCenterGroupId = table.Column<long>(type: "bigint", nullable: false),
                    IntResponsiblePersonId = table.Column<long>(type: "bigint", nullable: false),
                    IntAccountId = table.Column<long>(type: "bigint", nullable: false),
                    IntBusinessUnitId = table.Column<long>(type: "bigint", nullable: false),
                    IntActionBy = table.Column<long>(type: "bigint", nullable: false),
                    DteLastActionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DteServerDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCostCenter", x => x.IntCostCenterId);
                });

            migrationBuilder.CreateTable(
                name: "TblCountry",
                columns: table => new
                {
                    IntCountryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDialingCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrCountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntActionBy = table.Column<long>(type: "bigint", nullable: false),
                    DteLastActionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DteServerDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCountry", x => x.IntCountryId);
                });

            migrationBuilder.CreateTable(
                name: "TblDistrict",
                columns: table => new
                {
                    IntDistrictId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntDivisionId = table.Column<long>(type: "bigint", nullable: false),
                    StrDistrictGeocode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCountryId = table.Column<long>(type: "bigint", nullable: false),
                    IntActionBy = table.Column<long>(type: "bigint", nullable: false),
                    DteLastActionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DteServerDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDistrict", x => x.IntDistrictId);
                });

            migrationBuilder.CreateTable(
                name: "TblDivision",
                columns: table => new
                {
                    IntDivisionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrDivisionGeocode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDivision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCountryId = table.Column<long>(type: "bigint", nullable: false),
                    StrCountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    StrDivitionBanglaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDivision", x => x.IntDivisionId);
                });

            migrationBuilder.CreateTable(
                name: "TblEducationDegree",
                columns: table => new
                {
                    IntEducationDegreeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrEducationDegree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntLevelOfEducationId = table.Column<long>(type: "bigint", nullable: false),
                    StrLevelOfEducation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEducationDegree", x => x.IntEducationDegreeId);
                });

            migrationBuilder.CreateTable(
                name: "TblEmployeeDepartment",
                columns: table => new
                {
                    IntDepartmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrDepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntAccountId = table.Column<long>(type: "bigint", nullable: true),
                    IntBusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    StrRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntActionBy = table.Column<long>(type: "bigint", nullable: true),
                    DteLastActionDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DteServerDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCorporate = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmployeeDepartment", x => x.IntDepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "TblEmployeeDesignation",
                columns: table => new
                {
                    IntDesignationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrDesignationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDesignationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntAccountId = table.Column<long>(type: "bigint", nullable: true),
                    IntBusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    IntPosionId = table.Column<long>(type: "bigint", nullable: true),
                    SrtPositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsManagement = table.Column<bool>(type: "bit", nullable: true),
                    StrRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntActionBy = table.Column<long>(type: "bigint", nullable: true),
                    DteLastActionDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DteServerDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmployeeDesignation", x => x.IntDesignationId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblCostCenter");

            migrationBuilder.DropTable(
                name: "TblCountry");

            migrationBuilder.DropTable(
                name: "TblDistrict");

            migrationBuilder.DropTable(
                name: "TblDivision");

            migrationBuilder.DropTable(
                name: "TblEducationDegree");

            migrationBuilder.DropTable(
                name: "TblEmployeeDepartment");

            migrationBuilder.DropTable(
                name: "TblEmployeeDesignation");
        }
    }
}
