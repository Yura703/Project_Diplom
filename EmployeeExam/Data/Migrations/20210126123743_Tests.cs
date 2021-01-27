using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeExam.Data.Migrations
{
    public partial class Tests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storage_Test_Tests_id1",
                table: "Storage");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Questions_Question1Questions_id",
                table: "Test");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Questions_Question2Questions_id",
                table: "Test");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Questions_Question3Questions_id",
                table: "Test");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Questions_Questions_id",
                table: "Test");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Test",
                table: "Test");

            migrationBuilder.RenameTable(
                name: "Test",
                newName: "Tests");

            migrationBuilder.RenameIndex(
                name: "IX_Test_Questions_id",
                table: "Tests",
                newName: "IX_Tests_Questions_id");

            migrationBuilder.RenameIndex(
                name: "IX_Test_Question3Questions_id",
                table: "Tests",
                newName: "IX_Tests_Question3Questions_id");

            migrationBuilder.RenameIndex(
                name: "IX_Test_Question2Questions_id",
                table: "Tests",
                newName: "IX_Tests_Question2Questions_id");

            migrationBuilder.RenameIndex(
                name: "IX_Test_Question1Questions_id",
                table: "Tests",
                newName: "IX_Tests_Question1Questions_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "Tests_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storage_Tests_Tests_id1",
                table: "Storage",
                column: "Tests_id1",
                principalTable: "Tests",
                principalColumn: "Tests_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Questions_Question1Questions_id",
                table: "Tests",
                column: "Question1Questions_id",
                principalTable: "Questions",
                principalColumn: "Questions_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Questions_Question2Questions_id",
                table: "Tests",
                column: "Question2Questions_id",
                principalTable: "Questions",
                principalColumn: "Questions_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Questions_Question3Questions_id",
                table: "Tests",
                column: "Question3Questions_id",
                principalTable: "Questions",
                principalColumn: "Questions_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Questions_Questions_id",
                table: "Tests",
                column: "Questions_id",
                principalTable: "Questions",
                principalColumn: "Questions_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storage_Tests_Tests_id1",
                table: "Storage");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Questions_Question1Questions_id",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Questions_Question2Questions_id",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Questions_Question3Questions_id",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Questions_Questions_id",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.RenameTable(
                name: "Tests",
                newName: "Test");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_Questions_id",
                table: "Test",
                newName: "IX_Test_Questions_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_Question3Questions_id",
                table: "Test",
                newName: "IX_Test_Question3Questions_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_Question2Questions_id",
                table: "Test",
                newName: "IX_Test_Question2Questions_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_Question1Questions_id",
                table: "Test",
                newName: "IX_Test_Question1Questions_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test",
                table: "Test",
                column: "Tests_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storage_Test_Tests_id1",
                table: "Storage",
                column: "Tests_id1",
                principalTable: "Test",
                principalColumn: "Tests_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Questions_Question1Questions_id",
                table: "Test",
                column: "Question1Questions_id",
                principalTable: "Questions",
                principalColumn: "Questions_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Questions_Question2Questions_id",
                table: "Test",
                column: "Question2Questions_id",
                principalTable: "Questions",
                principalColumn: "Questions_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Questions_Question3Questions_id",
                table: "Test",
                column: "Question3Questions_id",
                principalTable: "Questions",
                principalColumn: "Questions_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Questions_Questions_id",
                table: "Test",
                column: "Questions_id",
                principalTable: "Questions",
                principalColumn: "Questions_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
