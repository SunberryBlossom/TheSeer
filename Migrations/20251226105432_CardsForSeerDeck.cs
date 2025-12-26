using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheSeer.Migrations
{
    /// <inheritdoc />
    public partial class CardsForSeerDeck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "DeckId", "ImageKey", "Name", "SuitOrGroup", "Value" },
                values: new object[,]
                {
                    { 1, 1, "", "The Fool", "Major Arcana", 0 },
                    { 2, 1, "", "The Magician", "Major Arcana", 1 },
                    { 3, 1, "", "The High Priestess", "Major Arcana", 2 },
                    { 4, 1, "", "The Empress", "Major Arcana", 3 },
                    { 5, 1, "", "The Emperor", "Major Arcana", 4 },
                    { 6, 1, "", "The Hierophant", "Major Arcana", 5 },
                    { 7, 1, "", "The Lovers", "Major Arcana", 6 },
                    { 8, 1, "", "The Chariot", "Major Arcana", 7 },
                    { 9, 1, "", "Strength", "Major Arcana", 8 },
                    { 10, 1, "", "The Hermit", "Major Arcana", 9 },
                    { 11, 1, "", "Wheel of Fortune", "Major Arcana", 10 },
                    { 12, 1, "", "Justice", "Major Arcana", 11 },
                    { 13, 1, "", "The Hanged Man", "Major Arcana", 12 },
                    { 14, 1, "", "Death", "Major Arcana", 13 },
                    { 15, 1, "", "Temperance", "Major Arcana", 14 },
                    { 16, 1, "", "The Devil", "Major Arcana", 15 },
                    { 17, 1, "", "The Tower", "Major Arcana", 16 },
                    { 18, 1, "", "The Star", "Major Arcana", 17 },
                    { 19, 1, "", "The Moon", "Major Arcana", 18 },
                    { 20, 1, "", "The Sun", "Major Arcana", 19 },
                    { 21, 1, "", "Judgement", "Major Arcana", 20 },
                    { 22, 1, "", "The World", "Major Arcana", 21 },
                    { 23, 1, "", "Ace of Trees", "Trees", 1 },
                    { 24, 1, "", "Two of Trees", "Trees", 2 },
                    { 25, 1, "", "Three of Trees", "Trees", 3 },
                    { 26, 1, "", "Four of Trees", "Trees", 4 },
                    { 27, 1, "", "Five of Trees", "Trees", 5 },
                    { 28, 1, "", "Six of Trees", "Trees", 6 },
                    { 29, 1, "", "Seven of Trees", "Trees", 7 },
                    { 30, 1, "", "Eight of Trees", "Trees", 8 },
                    { 31, 1, "", "Nine of Trees", "Trees", 9 },
                    { 32, 1, "", "Ten of Trees", "Trees", 10 },
                    { 33, 1, "", "Page of Trees", "Trees", 11 },
                    { 34, 1, "", "Knight of Trees", "Trees", 12 },
                    { 35, 1, "", "Queen of Trees", "Trees", 13 },
                    { 36, 1, "", "King of Trees", "Trees", 14 },
                    { 37, 1, "", "Ace of Books", "Books", 1 },
                    { 38, 1, "", "Two of Books", "Books", 2 },
                    { 39, 1, "", "Three of Books", "Books", 3 },
                    { 40, 1, "", "Four of Books", "Books", 4 },
                    { 41, 1, "", "Five of Books", "Books", 5 },
                    { 42, 1, "", "Six of Books", "Books", 6 },
                    { 43, 1, "", "Seven of Books", "Books", 7 },
                    { 44, 1, "", "Eight of Books", "Books", 8 },
                    { 45, 1, "", "Nine of Books", "Books", 9 },
                    { 46, 1, "", "Ten of Books", "Books", 10 },
                    { 47, 1, "", "Page of Books", "Books", 11 },
                    { 48, 1, "", "Knight of Books", "Books", 12 },
                    { 49, 1, "", "Queen of Books", "Books", 13 },
                    { 50, 1, "", "King of Books", "Books", 14 },
                    { 51, 1, "", "Ace of Teeth", "Teeth", 1 },
                    { 52, 1, "", "Two of Teeth", "Teeth", 2 },
                    { 53, 1, "", "Three of Teeth", "Teeth", 3 },
                    { 54, 1, "", "Four of Teeth", "Teeth", 4 },
                    { 55, 1, "", "Five of Teeth", "Teeth", 5 },
                    { 56, 1, "", "Six of Teeth", "Teeth", 6 },
                    { 57, 1, "", "Seven of Teeth", "Teeth", 7 },
                    { 58, 1, "", "Eight of Teeth", "Teeth", 8 },
                    { 59, 1, "", "Nine of Teeth", "Teeth", 9 },
                    { 60, 1, "", "Ten of Teeth", "Teeth", 10 },
                    { 61, 1, "", "Page of Teeth", "Teeth", 11 },
                    { 62, 1, "", "Knight of Teeth", "Teeth", 12 },
                    { 63, 1, "", "Queen of Teeth", "Teeth", 13 },
                    { 64, 1, "", "King of Teeth", "Teeth", 14 },
                    { 65, 1, "", "Ace of Ores", "Ores", 1 },
                    { 66, 1, "", "Two of Ores", "Ores", 2 },
                    { 67, 1, "", "Three of Ores", "Ores", 3 },
                    { 68, 1, "", "Four of Ores", "Ores", 4 },
                    { 69, 1, "", "Five of Ores", "Ores", 5 },
                    { 70, 1, "", "Six of Ores", "Ores", 6 },
                    { 71, 1, "", "Seven of Ores", "Ores", 7 },
                    { 72, 1, "", "Eight of Ores", "Ores", 8 },
                    { 73, 1, "", "Nine of Ores", "Ores", 9 },
                    { 74, 1, "", "Ten of Ores", "Ores", 10 },
                    { 75, 1, "", "Page of Ores", "Ores", 11 },
                    { 76, 1, "", "Knight of Ores", "Ores", 12 },
                    { 77, 1, "", "Queen of Ores", "Ores", 13 },
                    { 78, 1, "", "King of Ores", "Ores", 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 78);
        }
    }
}
