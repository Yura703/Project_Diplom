using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeExam.Data.Migrations
{
    public partial class MigrateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    dep_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dep_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dep_abvr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Head = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.dep_id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Questions_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Variant1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Variant2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Variant3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<byte>(type: "tinyint", nullable: false),
                    Var = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Questions_id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    title_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    var_id = table.Column<int>(type: "int", nullable: false),
                    gr_security = table.Column<int>(type: "int", nullable: false),
                    interval = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.title_id);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Tests_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions_1 = table.Column<int>(type: "int", nullable: false),
                    Questions_2 = table.Column<int>(type: "int", nullable: false),
                    Questions_3 = table.Column<int>(type: "int", nullable: false),
                    Questions_4 = table.Column<int>(type: "int", nullable: false),
                    Questions_id = table.Column<int>(type: "int", nullable: true),
                    Question1Questions_id = table.Column<int>(type: "int", nullable: true),
                    Question2Questions_id = table.Column<int>(type: "int", nullable: true),
                    Question3Questions_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Tests_id);
                    table.ForeignKey(
                        name: "FK_Test_Questions_Question1Questions_id",
                        column: x => x.Question1Questions_id,
                        principalTable: "Questions",
                        principalColumn: "Questions_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Test_Questions_Question2Questions_id",
                        column: x => x.Question2Questions_id,
                        principalTable: "Questions",
                        principalColumn: "Questions_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Test_Questions_Question3Questions_id",
                        column: x => x.Question3Questions_id,
                        principalTable: "Questions",
                        principalColumn: "Questions_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Test_Questions_Questions_id",
                        column: x => x.Questions_id,
                        principalTable: "Questions",
                        principalColumn: "Questions_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tabel_id = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passed = table.Column<bool>(type: "bit", nullable: true),
                    need_print = table.Column<bool>(type: "bit", nullable: true),
                    dep_id = table.Column<int>(type: "int", nullable: false),
                    title_id = table.Column<int>(type: "int", nullable: false),
                    NamberComission = table.Column<int>(type: "int", nullable: true),
                    Departmentdep_id = table.Column<int>(type: "int", nullable: true),
                    title_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_Departmentdep_id",
                        column: x => x.Departmentdep_id,
                        principalTable: "Departments",
                        principalColumn: "dep_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Titles_title_id1",
                        column: x => x.title_id1,
                        principalTable: "Titles",
                        principalColumn: "title_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Storage_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tests_id = table.Column<int>(type: "int", nullable: false),
                    Tabel_id = table.Column<int>(type: "int", nullable: false),
                    Data_Quest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Employee_id = table.Column<int>(type: "int", nullable: true),
                    Tests_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Storage_id);
                    table.ForeignKey(
                        name: "FK_Storage_Employees_Employee_id",
                        column: x => x.Employee_id,
                        principalTable: "Employees",
                        principalColumn: "Employee_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Storage_Test_Tests_id1",
                        column: x => x.Tests_id1,
                        principalTable: "Test",
                        principalColumn: "Tests_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WrongAnswer",
                columns: table => new
                {
                    WrongAnswers_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tabel_id = table.Column<int>(type: "int", nullable: false),
                    Questions_id = table.Column<int>(type: "int", nullable: false),
                    Question_number = table.Column<short>(type: "smallint", nullable: false),
                    Date_Test = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Employee_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WrongAnswer", x => x.WrongAnswers_id);
                    table.ForeignKey(
                        name: "FK_WrongAnswer_Employees_Employee_id",
                        column: x => x.Employee_id,
                        principalTable: "Employees",
                        principalColumn: "Employee_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Departmentdep_id",
                table: "Employees",
                column: "Departmentdep_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_title_id1",
                table: "Employees",
                column: "title_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_Employee_id",
                table: "Storage",
                column: "Employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_Tests_id1",
                table: "Storage",
                column: "Tests_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Question1Questions_id",
                table: "Test",
                column: "Question1Questions_id");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Question2Questions_id",
                table: "Test",
                column: "Question2Questions_id");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Question3Questions_id",
                table: "Test",
                column: "Question3Questions_id");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Questions_id",
                table: "Test",
                column: "Questions_id");

            migrationBuilder.CreateIndex(
                name: "IX_WrongAnswer_Employee_id",
                table: "WrongAnswer",
                column: "Employee_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "WrongAnswer");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
