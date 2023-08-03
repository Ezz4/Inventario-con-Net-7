using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaInventario.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCategoriaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bodegas",
                table: "Bodegas");

            migrationBuilder.RenameTable(
                name: "Bodegas",
                newName: "Bodega");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bodega",
                table: "Bodega",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bodega",
                table: "Bodega");

            migrationBuilder.RenameTable(
                name: "Bodega",
                newName: "Bodegas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bodegas",
                table: "Bodegas",
                column: "Id");
        }
    }
}
