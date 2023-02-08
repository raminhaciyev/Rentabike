using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class bikeupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Requirements",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rules",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Requirements",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Rules",
                table: "Bikes");
        }
    }
}
