using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_teamtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_HomeTeamTeamID",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_HomeTeamTeamID",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HomeTeamTeamID",
                table: "Matches");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_GuestTeamID",
                table: "Matches",
                column: "GuestTeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_GuestTeamID",
                table: "Matches",
                column: "GuestTeamID",
                principalTable: "Teams",
                principalColumn: "TeamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_GuestTeamID",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_GuestTeamID",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "HomeTeamTeamID",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamTeamID",
                table: "Matches",
                column: "HomeTeamTeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_HomeTeamTeamID",
                table: "Matches",
                column: "HomeTeamTeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
