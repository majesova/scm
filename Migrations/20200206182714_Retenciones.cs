using Microsoft.EntityFrameworkCore.Migrations;

namespace scm.Migrations
{
    public partial class Retenciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "IVAAplicado",
                table: "RegistroVales",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Retenciones",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retenciones", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Retenciones");

            migrationBuilder.DropColumn(
                name: "IVAAplicado",
                table: "RegistroVales");
        }
    }
}
