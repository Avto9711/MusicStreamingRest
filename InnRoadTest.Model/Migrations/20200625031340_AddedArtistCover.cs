using Microsoft.EntityFrameworkCore.Migrations;

namespace InnRoadTest.Model.Migrations
{
    public partial class AddedArtistCover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistCover",
                table: "Artists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistCover",
                table: "Artists");
        }
    }
}
