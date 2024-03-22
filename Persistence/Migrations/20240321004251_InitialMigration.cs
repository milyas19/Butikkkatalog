using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChainInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Chain = table.Column<string>(type: "TEXT", nullable: true),
                    ChainClassName = table.Column<string>(type: "TEXT", nullable: true),
                    ChainImage = table.Column<string>(type: "TEXT", nullable: true),
                    ChainNr = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChainInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpeningHoursSpecial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dato = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    OpenString = table.Column<string>(type: "TEXT", nullable: true),
                    Weekdays = table.Column<int>(type: "INTEGER", nullable: false),
                    Closed = table.Column<bool>(type: "INTEGER", nullable: false),
                    SpecialOpeningHours = table.Column<bool>(type: "INTEGER", nullable: false),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHoursSpecial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ChainInfoId = table.Column<int>(type: "INTEGER", nullable: true),
                    ChainId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsEcommerce = table.Column<bool>(type: "INTEGER", nullable: false),
                    NewspaperUrl = table.Column<string>(type: "TEXT", nullable: true),
                    InStoreServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Lat = table.Column<double>(type: "REAL", nullable: false),
                    Lng = table.Column<double>(type: "REAL", nullable: false),
                    OpeningHoursToday = table.Column<string>(type: "TEXT", nullable: true),
                    OpenNow = table.Column<bool>(type: "INTEGER", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Distance = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    SLag = table.Column<string>(type: "TEXT", nullable: true),
                    OrganizationNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OpeningHoursId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Store_ChainInfo_ChainInfoId",
                        column: x => x.ChainInfoId,
                        principalTable: "ChainInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InStoreServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MemberOffer = table.Column<bool>(type: "INTEGER", nullable: true),
                    Postnord = table.Column<bool>(type: "INTEGER", nullable: true),
                    Post = table.Column<bool>(type: "INTEGER", nullable: true),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InStoreServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InStoreServices_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OpeningHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dato = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    OpenString = table.Column<string>(type: "TEXT", nullable: true),
                    Weekdays = table.Column<int>(type: "INTEGER", nullable: false),
                    Closed = table.Column<bool>(type: "INTEGER", nullable: false),
                    SpecialOpeningHours = table.Column<bool>(type: "INTEGER", nullable: false),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpeningHours_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChainInfo",
                columns: new[] { "Id", "Chain", "ChainClassName", "ChainImage", "ChainNr" },
                values: new object[,]
                {
                    { 1, "Prix", "prix", "/assets/images/mapmarkers/01.png?7003341bcfe337a104c5a8ee79251d4d", "01" },
                    { 2, "Mega", "mega", "/assets/images/mapmarkers/03.png?d7b089ef57ad29e69c3520f42bc8aae1", "03" },
                    { 3, "Extra", "extra", "/assets/images/mapmarkers/07.png?938d3bb66e14f3c8dd9fc5b45feb4fce", "07" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InStoreServices_StoreId",
                table: "InStoreServices",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningHours_StoreId",
                table: "OpeningHours",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_ChainInfoId",
                table: "Store",
                column: "ChainInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InStoreServices");

            migrationBuilder.DropTable(
                name: "OpeningHours");

            migrationBuilder.DropTable(
                name: "OpeningHoursSpecial");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "ChainInfo");
        }
    }
}
