using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeExam.Data.Migrations
{
    public partial class ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberTicket",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberTicket",
                table: "Tests");
        }
    }
}
