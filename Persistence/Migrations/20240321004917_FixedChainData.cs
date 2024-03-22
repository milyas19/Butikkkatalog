using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixedChainData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChainInfo",
                columns: new[] { "Id", "Chain", "ChainClassName", "ChainImage", "ChainNr" },
                values: new object[,]
                {
                    { 1, "Prix", "prix", "/assets/images/mapmarkers/01.png?7003341bcfe337a104c5a8ee79251d4d", "01" },
                    { 2, "Mega", "mega", "/assets/images/mapmarkers/03.png?d7b089ef57ad29e69c3520f42bc8aae1", "03" },
                    { 3, "Extra", "extra", "/assets/images/mapmarkers/07.png?938d3bb66e14f3c8dd9fc5b45feb4fce", "07" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChainInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChainInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChainInfo",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
