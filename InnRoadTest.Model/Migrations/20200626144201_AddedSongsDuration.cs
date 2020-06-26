using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnRoadTest.Model.Migrations
{
    public partial class AddedSongsDuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AlbumRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "AlbumRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "MusicLabels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "MusicLabels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 36, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 38, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 6, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 43, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 37, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 2, 53, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 2, 59, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 8, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 26, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 42, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720), new TimeSpan(0, 0, 3, 31, 0) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AlbumRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "AlbumRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "MusicLabels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "MusicLabels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Duration" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0) });
        }
    }
}
