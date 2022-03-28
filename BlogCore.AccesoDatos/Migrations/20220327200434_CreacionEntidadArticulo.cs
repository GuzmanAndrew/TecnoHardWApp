using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.AccesoDatos.Migrations
{
    public partial class CreacionEntidadArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Precio",
                table: "Articulo",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Proveedor",
                table: "Articulo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Articulo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "Proveedor",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Articulo");
        }
    }
}
