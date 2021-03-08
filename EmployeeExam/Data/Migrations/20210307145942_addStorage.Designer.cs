﻿// <auto-generated />
using System;
using EmployeeExam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeExam.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210307145942_addStorage")]
    partial class addStorage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EmployeeExam.Data.Entities.Comission", b =>
                {
                    b.Property<int>("Comission_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Head")
                        .HasColumnType("bit");

                    b.Property<int>("NamberComission")
                        .HasColumnType("int");

                    b.HasKey("Comission_id");

                    b.ToTable("Comissions");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Department", b =>
                {
                    b.Property<int>("dep_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Head")
                        .HasColumnType("bit");

                    b.Property<string>("dep_abvr")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("dep_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("dep_id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Employee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Departmentdep_id")
                        .HasColumnType("int");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NamberComission")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tabel_id")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("dep_id")
                        .HasColumnType("int");

                    b.Property<bool?>("need_print")
                        .HasColumnType("bit");

                    b.Property<bool?>("passed")
                        .HasColumnType("bit");

                    b.Property<int>("title_id")
                        .HasColumnType("int");

                    b.Property<int?>("title_id1")
                        .HasColumnType("int");

                    b.HasKey("Employee_id");

                    b.HasIndex("Departmentdep_id");

                    b.HasIndex("title_id1");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Question", b =>
                {
                    b.Property<int>("Questions_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte>("Answer")
                        .HasColumnType("tinyint");

                    b.Property<string>("Quest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Var")
                        .HasColumnType("int");

                    b.Property<string>("Variant1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variant2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variant3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Questions_id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Storage", b =>
                {
                    b.Property<int>("Storage_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Data_Quest")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Employee_id")
                        .HasColumnType("int");

                    b.Property<bool>("Result")
                        .HasColumnType("bit");

                    b.Property<int>("Tabel_id")
                        .HasColumnType("int");

                    b.Property<int>("Tests_id")
                        .HasColumnType("int");

                    b.Property<int?>("Tests_id1")
                        .HasColumnType("int");

                    b.HasKey("Storage_id");

                    b.HasIndex("Employee_id");

                    b.HasIndex("Tests_id1");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Test", b =>
                {
                    b.Property<int>("Tests_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Question1Questions_id")
                        .HasColumnType("int");

                    b.Property<int?>("Question2Questions_id")
                        .HasColumnType("int");

                    b.Property<int?>("Question3Questions_id")
                        .HasColumnType("int");

                    b.Property<int>("Questions_1")
                        .HasColumnType("int");

                    b.Property<int>("Questions_2")
                        .HasColumnType("int");

                    b.Property<int>("Questions_3")
                        .HasColumnType("int");

                    b.Property<int>("Questions_4")
                        .HasColumnType("int");

                    b.Property<int?>("Questions_id")
                        .HasColumnType("int");

                    b.Property<int>("Variant")
                        .HasColumnType("int");

                    b.HasKey("Tests_id");

                    b.HasIndex("Question1Questions_id");

                    b.HasIndex("Question2Questions_id");

                    b.HasIndex("Question3Questions_id");

                    b.HasIndex("Questions_id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Title", b =>
                {
                    b.Property<int>("title_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("gr_security")
                        .HasColumnType("int");

                    b.Property<int>("interval")
                        .HasColumnType("int");

                    b.Property<string>("title_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("var_id")
                        .HasColumnType("int");

                    b.HasKey("title_id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.WrongAnswer", b =>
                {
                    b.Property<int>("WrongAnswers_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date_Test")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Employee_id")
                        .HasColumnType("int");

                    b.Property<short>("Question_number")
                        .HasColumnType("smallint");

                    b.Property<int>("Questions_id")
                        .HasColumnType("int");

                    b.Property<int>("Tabel_id")
                        .HasColumnType("int");

                    b.HasKey("WrongAnswers_id");

                    b.HasIndex("Employee_id");

                    b.ToTable("WrongAnswer");
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Employee", b =>
                {
                    b.HasOne("EmployeeExam.Data.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("Departmentdep_id");

                    b.HasOne("EmployeeExam.Data.Entities.Title", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("title_id1");

                    b.Navigation("Department");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Storage", b =>
                {
                    b.HasOne("EmployeeExam.Data.Entities.Employee", "Employee")
                        .WithMany("Storages")
                        .HasForeignKey("Employee_id");

                    b.HasOne("EmployeeExam.Data.Entities.Test", "Test")
                        .WithMany("Storages")
                        .HasForeignKey("Tests_id1");

                    b.Navigation("Employee");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Test", b =>
                {
                    b.HasOne("EmployeeExam.Data.Entities.Question", "Question1")
                        .WithMany()
                        .HasForeignKey("Question1Questions_id");

                    b.HasOne("EmployeeExam.Data.Entities.Question", "Question2")
                        .WithMany()
                        .HasForeignKey("Question2Questions_id");

                    b.HasOne("EmployeeExam.Data.Entities.Question", "Question3")
                        .WithMany()
                        .HasForeignKey("Question3Questions_id");

                    b.HasOne("EmployeeExam.Data.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("Questions_id");

                    b.Navigation("Question");

                    b.Navigation("Question1");

                    b.Navigation("Question2");

                    b.Navigation("Question3");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.WrongAnswer", b =>
                {
                    b.HasOne("EmployeeExam.Data.Entities.Employee", "Employee")
                        .WithMany("WrongAnswers")
                        .HasForeignKey("Employee_id");

                    b.Navigation("Employee");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Employee", b =>
                {
                    b.Navigation("Storages");

                    b.Navigation("WrongAnswers");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Test", b =>
                {
                    b.Navigation("Storages");
                });

            modelBuilder.Entity("EmployeeExam.Data.Entities.Title", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
