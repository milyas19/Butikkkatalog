using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddStoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "InStoreServices",
                columns: new[] { "Id", "MemberOffer", "Post", "Postnord", "StoreId" },
                values: new object[,]
                {
                    { 1, true, false, true, null },
                    { 2, true, false, true, null },
                    { 3, true, false, true, null },
                    { 4, true, false, true, null },
                    { 5, true, false, true, null },
                    { 6, true, false, true, null },
                    { 7, true, false, true, null }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Address", "ChainId", "ChainInfoId", "City", "Distance", "Email", "InStoreServiceId", "IsEcommerce", "Lat", "Lng", "Name", "NewspaperUrl", "OpenNow", "OpeningHoursId", "OpeningHoursToday", "OrganizationNumber", "Phone", "SLag", "StoreId" },
                values: new object[,]
                {
                    { 1, "NILS LAURITSSØNSV. 57, 0870 OSLO", 1, null, "Oslo", 0, "tasen.prix@coop.no", 6, false, 59.949938000000003, 10.749888, "Tåsen", "http://kundeavis.coop.no/aviser/?id=4238", true, 0, "07:00-23:00", "931186744", "22237700", "NORSK BUTIKKDRIFT AS", 4238 },
                    { 2, "SOGNSVEIEN 77C, 0855 OSLO", 2, null, "Oslo", 0, "ulleval.mega@coop.no", 4, false, 59.949938000000003, 10.736036500000001, "Ullevål", "http://kundeavis.coop.no/aviser/?id=4292", true, 0, "07:00-22:00", "931186744", "22581660", "NORSK BUTIKKDRIFT AS", 4292 },
                    { 3, "NYDALSVEIEN 33, 0484 OSLO", 2, null, "Oslo", 0, "nydalen.mega@coop.no", 0, false, 59.949565, 10.765788799999999, "Nydalen", "http://kundeavis.coop.no/aviser/?id=4941", true, 0, "07:00-23:00", "931186744", "23260630", "NORSK BUTIKKDRIFT AS", 4941 },
                    { 4, "HAMMERGT. 1, 0465 OSLO", 3, null, "Oslo", 0, "bjolsen.extra@coop.no", 2, false, 59.938276299999998, 10.757130800000001, "Bjølsen", "http://kundeavis.coop.no/aviser/?id=4280", true, 0, "07:00-23:00", "931186744", "94176699", "NORSK BUTIKKDRIFT AS", 4280 },
                    { 5, "VITAMINVEIEN 7/9, 0485 OSLO", 2, null, "Oslo", 0, "storo.mega@coop.no", 0, false, 59.946842199999999, 10.7753876, "Storo", "http://kundeavis.coop.no/aviser/?id=4312", true, 0, "07:00-23:00", "931186744", "23058080", "NORSK BUTIKKDRIFT AS", 4312 },
                    { 6, "GREFSENVN.26, 0482 OSLO", 3, null, "Oslo", 0, "storo.extra@coop.no", 7, false, 59.943248099999998, 10.7738134, "Storo", "http://kundeavis.coop.no/aviser/?id=1125", true, 0, "07:00-23:00", "948432617", "22222140", "COOP ØST SA", 1125 },
                    { 7, "THURMANNSGT 12B, 0461 OSLO", 3, null, "Oslo", 0, "sagene.extra@coop.no", 3, false, 59.935544200000002, 10.7525795, "Sagene", "http://kundeavis.coop.no/aviser/?id=4226", true, 0, "07:00-23:00", "916510101", "22389370", null, 4226 }
                });

            migrationBuilder.InsertData(
                table: "OpeningHours",
                columns: new[] { "Id", "Closed", "Dato", "OpenString", "SpecialOpeningHours", "StoreId", "Weekdays" },
                values: new object[,]
                {
                    { 1, false, new DateOnly(2024, 3, 19), "07:00-23:00", false, 7, 1 },
                    { 2, false, new DateOnly(2024, 3, 20), "07:00-23:00", false, 1, 2 },
                    { 3, false, new DateOnly(2024, 3, 21), "07:00-23:00", false, 1, 3 },
                    { 4, false, new DateOnly(2024, 3, 22), "07:00-23:00", false, 1, 4 },
                    { 5, false, new DateOnly(2024, 3, 23), "08:00-21:00", false, 1, 5 },
                    { 6, true, new DateOnly(2024, 3, 24), "Stengt", false, 1, 6 },
                    { 7, false, new DateOnly(2024, 3, 19), "07:00-23:00", false, 1, 1 },
                    { 8, false, new DateOnly(2024, 3, 20), "07:00-23:00", false, 1, 2 },
                    { 9, false, new DateOnly(2024, 3, 21), "07:00-23:00", false, 1, 3 },
                    { 10, false, new DateOnly(2024, 3, 22), "07:00-23:00", false, 2, 4 },
                    { 11, false, new DateOnly(2024, 3, 23), "08:00-21:00", false, 2, 5 },
                    { 12, true, new DateOnly(2024, 3, 24), "Stengt", false, 2, 6 },
                    { 13, false, new DateOnly(2024, 3, 19), "07:00-23:00", false, 2, 1 },
                    { 14, false, new DateOnly(2024, 3, 20), "07:00-23:00", false, 2, 2 },
                    { 15, false, new DateOnly(2024, 3, 21), "07:00-23:00", false, 2, 3 },
                    { 16, false, new DateOnly(2024, 3, 22), "07:00-23:00", false, 2, 4 },
                    { 17, false, new DateOnly(2024, 3, 23), "08:00-21:00", false, 3, 5 },
                    { 18, true, new DateOnly(2024, 3, 24), "Stengt", false, 3, 6 },
                    { 19, false, new DateOnly(2024, 3, 19), "07:00-23:00", false, 3, 1 },
                    { 20, false, new DateOnly(2024, 3, 20), "07:00-23:00", false, 3, 2 },
                    { 21, false, new DateOnly(2024, 3, 21), "07:00-23:00", false, 3, 3 },
                    { 22, false, new DateOnly(2024, 3, 22), "07:00-23:00", false, 3, 4 },
                    { 23, false, new DateOnly(2024, 3, 23), "08:00-21:00", false, 3, 5 },
                    { 24, true, new DateOnly(2024, 3, 24), "Stengt", false, 4, 6 },
                    { 25, false, new DateOnly(2024, 3, 19), "07:00-23:00", false, 4, 1 },
                    { 26, false, new DateOnly(2024, 3, 20), "07:00-23:00", false, 4, 2 },
                    { 27, false, new DateOnly(2024, 3, 21), "07:00-23:00", false, 4, 3 },
                    { 28, false, new DateOnly(2024, 3, 22), "07:00-23:00", false, 4, 4 },
                    { 29, false, new DateOnly(2024, 3, 23), "08:00-21:00", false, 4, 5 },
                    { 30, true, new DateOnly(2024, 3, 24), "Stengt", false, 4, 6 },
                    { 31, false, new DateOnly(2024, 3, 19), "07:00-23:00", false, 5, 1 },
                    { 32, false, new DateOnly(2024, 3, 20), "07:00-23:00", false, 5, 2 },
                    { 33, false, new DateOnly(2024, 3, 21), "07:00-23:00", false, 5, 3 },
                    { 34, false, new DateOnly(2024, 3, 22), "07:00-23:00", false, 5, 4 },
                    { 35, false, new DateOnly(2024, 3, 23), "08:00-21:00", false, 5, 5 },
                    { 36, true, new DateOnly(2024, 3, 24), "Stengt", false, 5, 6 },
                    { 37, false, new DateOnly(2024, 3, 19), "07:00-23:00", false, 5, 1 },
                    { 38, false, new DateOnly(2024, 3, 20), "07:00-23:00", false, 6, 2 },
                    { 39, false, new DateOnly(2024, 3, 21), "07:00-23:00", false, 6, 3 },
                    { 40, false, new DateOnly(2024, 3, 22), "07:00-23:00", false, 6, 4 },
                    { 41, false, new DateOnly(2024, 3, 23), "08:00-21:00", false, 6, 5 },
                    { 42, true, new DateOnly(2024, 3, 24), "Stengt", false, 6, 6 },
                    { 43, false, new DateOnly(2024, 3, 19), "07:00-23:00", false, 6, 1 },
                    { 44, false, new DateOnly(2024, 3, 20), "07:00-23:00", false, 6, 2 },
                    { 45, false, new DateOnly(2024, 3, 21), "07:00-23:00", false, 7, 3 },
                    { 46, false, new DateOnly(2024, 3, 22), "07:00-23:00", false, 7, 4 },
                    { 47, false, new DateOnly(2024, 3, 23), "08:00-21:00", false, 7, 5 },
                    { 48, true, new DateOnly(2024, 3, 24), "Stengt", false, 7, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InStoreServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InStoreServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InStoreServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InStoreServices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InStoreServices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InStoreServices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InStoreServices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "OpeningHours",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
