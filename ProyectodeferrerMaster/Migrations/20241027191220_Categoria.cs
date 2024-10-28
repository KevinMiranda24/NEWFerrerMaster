using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectodeferrerMaster.Migrations
{
    /// <inheritdoc />
    public partial class Categoria : Migration
    {
        /// <inheritdoc />
protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.CreateTable(
        name: "Categorias",
        columns: table => new
        {
            IdCategoria = table.Column<int>(nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
            NombreCategoria = table.Column<string>(nullable: true)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
        });
}


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
