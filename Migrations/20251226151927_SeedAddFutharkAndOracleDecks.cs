using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheSeer.Migrations
{
    /// <inheritdoc />
    public partial class SeedAddFutharkAndOracleDecks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Decks",
                columns: new[] { "Id", "AssetFolder", "CardBackImage", "Creator", "DateOfPublish", "Description", "IsLocked", "Name", "SystemTypeId" },
                values: new object[,]
                {
                    { 3, " ", " ", "Elvira Mariesdotter", new DateOnly(2025, 12, 26), "Oracle cards represented by the spirits of the dunes in the land of the Seer. Includes 44 cards meant to guide you when doubt is clouding your vision.", false, "The oracles of the dunes", 3 },
                    { 4, " ", " ", "Elvira Mariesdotter", new DateOnly(2025, 12, 26), "A set of 24 old futhark runes. Standard rune set for fortune telling used by the ancient norse.", false, "Elder futhark runes", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
