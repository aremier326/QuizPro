using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizPro.DAL.Migrations
{
    public partial class small_changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Result",
                table: "Tests",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestType",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TestType",
                table: "Tests");
        }
    }
}
