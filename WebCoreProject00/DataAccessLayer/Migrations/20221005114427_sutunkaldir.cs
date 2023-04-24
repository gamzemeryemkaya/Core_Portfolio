using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class sutunkaldir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Portfolios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Image1",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Image2",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Image3",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Image4",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Value",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
