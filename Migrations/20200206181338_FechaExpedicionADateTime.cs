using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace scm.Migrations
{
    public partial class FechaExpedicionADateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaExpedicionVale",
                table: "Vales",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FechaExpedicionVale",
                table: "Vales",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
