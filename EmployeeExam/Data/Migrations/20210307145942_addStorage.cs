using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeExam.Data.Migrations
{
    public partial class addStorage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Result",
                table: "Storage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Comissions",
                columns: table => new
                {
                    Comission_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamberComission = table.Column<int>(type: "int", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Head = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comissions", x => x.Comission_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comissions");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Storage");
        }
    }
}
