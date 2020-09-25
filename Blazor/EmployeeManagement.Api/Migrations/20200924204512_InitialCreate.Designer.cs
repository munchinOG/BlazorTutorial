﻿// <auto-generated />
using System;
using EmployeeManagement.Api.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Api.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20200924204512_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 201,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentId = 202,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentId = 203,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentId = 204,
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 101,
                            DateOfBirth = new DateTime(1988, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 201,
                            Email = "Mello@munchinOG.com",
                            FirstName = "Mello",
                            Gender = 0,
                            LastName = "Sky",
                            PhotoPath = "images/mello.png"
                        },
                        new
                        {
                            EmployeeId = 102,
                            DateOfBirth = new DateTime(1980, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 202,
                            Email = "Kate@munchinOG.com",
                            FirstName = "Kate",
                            Gender = 0,
                            LastName = "Utibe",
                            PhotoPath = "images/kate.png"
                        },
                        new
                        {
                            EmployeeId = 103,
                            DateOfBirth = new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 203,
                            Email = "Queen@munchinOG.com",
                            FirstName = "Queen",
                            Gender = 0,
                            LastName = "John",
                            PhotoPath = "images/queen.png"
                        },
                        new
                        {
                            EmployeeId = 104,
                            DateOfBirth = new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 204,
                            Email = "Sam@munchinOG.com",
                            FirstName = "Sam",
                            Gender = 0,
                            LastName = "Galloway",
                            PhotoPath = "images/sam.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}