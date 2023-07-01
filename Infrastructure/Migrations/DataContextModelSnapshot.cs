﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApi.Context;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Emount")
                        .HasColumnType("numeric");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Salarys");
                });

            modelBuilder.Entity("WebApi.Entities.Department", b =>
                {
                    b.Property<int>("DepatrmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DepatrmentId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("DepatrmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("WebApi.Entities.DepartmentEmployee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int>("DepatrmentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("EmployeeId", "DepatrmentId");

                    b.HasIndex("DepatrmentId");

                    b.ToTable("DepartmentEmployees");
                });

            modelBuilder.Entity("WebApi.Entities.DepartmentManager", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int>("DepatrmentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("EmployeeId", "DepatrmentId");

                    b.HasIndex("DepatrmentId");

                    b.ToTable("DepartmentManagers");
                });

            modelBuilder.Entity("WebApi.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("BithDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApi.Entities.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ManagerId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<int>("FullName")
                        .HasColumnType("integer");

                    b.HasKey("ManagerId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("Salary", b =>
                {
                    b.HasOne("WebApi.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("WebApi.Entities.DepartmentEmployee", b =>
                {
                    b.HasOne("WebApi.Entities.Department", "Depatrment")
                        .WithMany("DepartmentEmployees")
                        .HasForeignKey("DepatrmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Entities.Employee", "Employee")
                        .WithMany("DepartmentEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depatrment");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("WebApi.Entities.DepartmentManager", b =>
                {
                    b.HasOne("WebApi.Entities.Department", "Depatrment")
                        .WithMany("DepartmentManagers")
                        .HasForeignKey("DepatrmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Entities.Employee", "Employee")
                        .WithMany("DepartmentManagers")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depatrment");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("WebApi.Entities.Manager", b =>
                {
                    b.HasOne("WebApi.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApi.Entities.Department", b =>
                {
                    b.Navigation("DepartmentEmployees");

                    b.Navigation("DepartmentManagers");
                });

            modelBuilder.Entity("WebApi.Entities.Employee", b =>
                {
                    b.Navigation("DepartmentEmployees");

                    b.Navigation("DepartmentManagers");
                });
#pragma warning restore 612, 618
        }
    }
}