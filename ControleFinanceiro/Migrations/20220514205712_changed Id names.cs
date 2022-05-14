using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleFinanceiro.Migrations
{
    public partial class changedIdnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenditureId",
                table: "Revenue",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ExpenditureId",
                table: "Expenditure",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Revenue",
                newName: "ExpenditureId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Expenditure",
                newName: "ExpenditureId");
        }
    }
}
