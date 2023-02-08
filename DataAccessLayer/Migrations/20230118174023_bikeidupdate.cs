using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class bikeidupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReserveBikeMessages_Bikes_BikeId",
                table: "ReserveBikeMessages");

            migrationBuilder.AlterColumn<int>(
                name: "BikeId",
                table: "ReserveBikeMessages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReserveBikeMessages_Bikes_BikeId",
                table: "ReserveBikeMessages",
                column: "BikeId",
                principalTable: "Bikes",
                principalColumn: "BikeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReserveBikeMessages_Bikes_BikeId",
                table: "ReserveBikeMessages");

            migrationBuilder.AlterColumn<int>(
                name: "BikeId",
                table: "ReserveBikeMessages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ReserveBikeMessages_Bikes_BikeId",
                table: "ReserveBikeMessages",
                column: "BikeId",
                principalTable: "Bikes",
                principalColumn: "BikeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
