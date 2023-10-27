using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICodeCraft.Migrations
{
    /// <inheritdoc />
    public partial class UrlImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Subtopics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Quizs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Subtopics");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Quizs");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Contents");
        }
    }
}
