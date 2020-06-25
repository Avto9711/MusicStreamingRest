using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnRoadTest.Model.Migrations
{
    public partial class AddingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "ArtistCover", "CreatedBy", "CreatedDate", "Deleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, "Basckstreet boys", null, null });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Deleted", "Description", "Name", "ParentGenreId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, null, "Pop", null, null, null });

            migrationBuilder.InsertData(
                table: "MusicLabels",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Deleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, "K-Bahn, LLC", null, null },
                    { 2, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, "RCA Records", null, null }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumCover", "ArtistId", "CreatedBy", "CreatedDate", "Deleted", "GenreId", "Name", "Price", "ReleaseDate", "Review", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "https://is2-ssl.mzstatic.com/image/thumb/Music128/v4/fb/32/2e/fb322ed2-a171-4909-86f0-7bf487a7b811/886447390108.jpg/1000x1000bb.jpg", 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, 1, "DNA", 11.99, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "There’s one question the Backstreet Boys can’t seem to escape: Do they still consider themselves a boy band? The five-piece, most of whom are now over 40 and married with children, have come to embrace the term. “At this point, ‘boys' has come to mean more, like, ‘friends,’ Kevin Richardson told Apple Music’s Arjan Timmermans. “It keeps us young.” There might be some truth to that.On their ninth album DNA , the group dabbles in the sounds that are driving mainstream music in 2019: mid-tempo EDM (“Don’t Go Breaking My Heart”), ’80s-inspired synth-pop (“Is It Just Me”), and heart-on-sleeve country (“You’re my daybreak/You’re my California sun/You’re my Memphis, New York, New Orleans all rolled into one,” they croon on “No Place”). Even when they’re experimenting, though, they always feel familiar—they’ve still got those irresistible five-part harmonies, R&B leanings, and swoonworthy come-ons that made fans fall in love with them 25 years ago. The slick and swaggering “New Love” sounds like classic BSB. “There are moments when all five of us are like, ‘Oh, dude, absolutely,’” Brian Littrell said of the moment they first heard the song. “That’s what you’re striving for.”", null, null });

            migrationBuilder.InsertData(
                table: "AlbumMusicLabels",
                columns: new[] { "Id", "AlbumId", "Deleted", "MusicLabelId" },
                values: new object[,]
                {
                    { 1, 1, false, 1 },
                    { 2, 1, false, 2 }
                });

            migrationBuilder.InsertData(
                table: "AlbumRates",
                columns: new[] { "Id", "AlbumId", "CreatedBy", "CreatedDate", "Deleted", "PointsGiven", "RateMesssage", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, 4.0, "Great Album", null, null },
                    { 2, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, 5.0, "Excellent Album", null, null }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedBy", "CreatedDate", "Deleted", "Duration", "Name", "Popularity", "Price", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Don't Go Breaking My Heart", 5.0, 1.29, null, null },
                    { 2, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Nobody Else", 5.0, 1.29, null, null },
                    { 3, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Breathe", 5.0, 1.29, null, null },
                    { 4, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "New Love", 0.0, 1.29, null, null },
                    { 5, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Passionate", 0.0, 1.29, null, null },
                    { 6, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Is Just Me", 0.0, 1.29, null, null },
                    { 7, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Chances", 0.0, 1.29, null, null },
                    { 8, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "No Place", 0.0, 1.29, null, null },
                    { 9, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Chateau", 0.0, 1.29, null, null },
                    { 10, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "The Way It Was", 0.0, 1.29, null, null },
                    { 11, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Just Like You Like It", 0.0, 1.29, null, null },
                    { 12, 1, null, new DateTime(2020, 6, 25, 18, 11, 45, 285, DateTimeKind.Local).AddTicks(5086), false, new TimeSpan(0, 0, 0, 0, 0), "Ok", 0.0, 1.29, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumMusicLabels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AlbumMusicLabels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AlbumRates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AlbumRates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicLabels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicLabels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
