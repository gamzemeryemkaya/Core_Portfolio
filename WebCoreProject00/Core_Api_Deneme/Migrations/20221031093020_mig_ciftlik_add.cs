using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_Api_Deneme.Migrations
{
    public partial class mig_ciftlik_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MakuCiftliks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SagımID = table.Column<int>(type: "int", nullable: false),
                    HayvanID = table.Column<int>(type: "int", nullable: false),
                    CiftlikID = table.Column<int>(type: "int", nullable: false),
                    SutMiktari = table.Column<int>(type: "int", nullable: false),
                    SagimSuresi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakuCiftliks", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MakuCiftliks");
        }
    }
}
