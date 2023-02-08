using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class faqupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Faqs",
                newName: "Text5");

            migrationBuilder.AddColumn<string>(
                name: "Question1",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question2",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question3",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question4",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question5",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text1",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text2",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text3",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text4",
                table: "Faqs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Question1",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Question2",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Question3",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Question4",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Question5",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Text1",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Text2",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Text3",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Text4",
                table: "Faqs");

            migrationBuilder.RenameColumn(
                name: "Text5",
                table: "Faqs",
                newName: "Text");
        }
    }
}
