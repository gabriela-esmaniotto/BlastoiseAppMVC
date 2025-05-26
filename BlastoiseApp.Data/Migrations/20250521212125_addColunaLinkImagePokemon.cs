using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlastoiseApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addColunaLinkImagePokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkImage",
                table: "Pokemon",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Link da imagem do pokémon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkImage",
                table: "Pokemon");
        }
    }
}
