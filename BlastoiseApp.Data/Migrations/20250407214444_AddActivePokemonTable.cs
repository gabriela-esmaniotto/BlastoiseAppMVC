using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlastoiseApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddActivePokemonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Pokemon",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Pokemon");
        }
    }
}
