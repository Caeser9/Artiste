using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class retouche : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chansons_Artistes_ArtisteId",
                table: "Chansons");

            migrationBuilder.RenameColumn(
                name: "ArtisteId",
                table: "Chansons",
                newName: "ArtisteFk");

            migrationBuilder.RenameIndex(
                name: "IX_Chansons_ArtisteId",
                table: "Chansons",
                newName: "IX_Chansons_ArtisteFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Chansons_Artistes_ArtisteFk",
                table: "Chansons",
                column: "ArtisteFk",
                principalTable: "Artistes",
                principalColumn: "ArtisteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chansons_Artistes_ArtisteFk",
                table: "Chansons");

            migrationBuilder.RenameColumn(
                name: "ArtisteFk",
                table: "Chansons",
                newName: "ArtisteId");

            migrationBuilder.RenameIndex(
                name: "IX_Chansons_ArtisteFk",
                table: "Chansons",
                newName: "IX_Chansons_ArtisteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chansons_Artistes_ArtisteId",
                table: "Chansons",
                column: "ArtisteId",
                principalTable: "Artistes",
                principalColumn: "ArtisteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
