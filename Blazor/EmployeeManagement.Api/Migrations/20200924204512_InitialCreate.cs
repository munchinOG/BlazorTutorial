using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 201, "IT" },
                    { 202, "HR" },
                    { 203, "Payroll" },
                    { 204, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 101, new DateTime(1988, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 201, "Mello@munchinOG.com", "Mello", 0, "Sky", "images/mello.png" },
                    { 102, new DateTime(1980, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 202, "Kate@munchinOG.com", "Kate", 0, "Utibe", "images/kate.png" },
                    { 103, new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 203, "Queen@munchinOG.com", "Queen", 0, "John", "images/queen.png" },
                    { 104, new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 204, "Sam@munchinOG.com", "Sam", 0, "Galloway", "images/sam.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
