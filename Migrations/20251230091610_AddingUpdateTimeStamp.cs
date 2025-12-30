using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSeer.Migrations
{
    /// <inheritdoc />
    public partial class AddingUpdateTimeStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "JournalEntries",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "JournalEntries");
        }
    }
}
