using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeExam.Data.Migrations
{
    public partial class addStorage1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Comissions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Comissions");
        }
    }
}
