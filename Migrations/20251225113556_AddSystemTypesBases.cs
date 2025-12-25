using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheSeer.Migrations
{
    /// <inheritdoc />
    public partial class AddSystemTypesBases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SystemTypes",
                columns: new[] { "Id", "CanBeReversed", "DefaultCardCount", "Description", "Name" },
                values: new object[,]
                {
                    { 1, true, 78, "The classical system for introspection, guidance and spirital development. Usually has 78 cards, always divided into the major and minor arcana.", "Tarot" },
                    { 2, true, 24, "An old norse system built upon the old futhark of 24 runes. Each rune symbolize natural powers and gods or godesses. Used to interpret hidden energies and bigger happenings in life.", "Runes" },
                    { 3, false, 44, "A free and intuitive system for guidance. Not as strict as the Tarot system. Usually have unique themes, and can be flexible regarding card count.", "Oracle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SystemTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SystemTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SystemTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
