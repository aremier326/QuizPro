using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizPro.DAL.Migrations
{
    public partial class small_changes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestType",
                table: "Quizzes",
                newName: "QuizType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuizType",
                table: "Quizzes",
                newName: "TestType");
        }
    }
}
