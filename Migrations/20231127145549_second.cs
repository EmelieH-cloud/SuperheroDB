using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperheroDB.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperheroSuperpowers_Heroes_SuperheroId",
                table: "SuperheroSuperpowers");

            migrationBuilder.DropForeignKey(
                name: "FK_SuperheroSuperpowers_Powers_SuperpowerId",
                table: "SuperheroSuperpowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperheroSuperpowers",
                table: "SuperheroSuperpowers");

            migrationBuilder.RenameTable(
                name: "SuperheroSuperpowers",
                newName: "superPowers");

            migrationBuilder.RenameIndex(
                name: "IX_SuperheroSuperpowers_SuperpowerId",
                table: "superPowers",
                newName: "IX_superPowers_SuperpowerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_superPowers",
                table: "superPowers",
                columns: new[] { "SuperheroId", "SuperpowerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_superPowers_Heroes_SuperheroId",
                table: "superPowers",
                column: "SuperheroId",
                principalTable: "Heroes",
                principalColumn: "SuperheroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_superPowers_Powers_SuperpowerId",
                table: "superPowers",
                column: "SuperpowerId",
                principalTable: "Powers",
                principalColumn: "SuperpowerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_superPowers_Heroes_SuperheroId",
                table: "superPowers");

            migrationBuilder.DropForeignKey(
                name: "FK_superPowers_Powers_SuperpowerId",
                table: "superPowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_superPowers",
                table: "superPowers");

            migrationBuilder.RenameTable(
                name: "superPowers",
                newName: "SuperheroSuperpowers");

            migrationBuilder.RenameIndex(
                name: "IX_superPowers_SuperpowerId",
                table: "SuperheroSuperpowers",
                newName: "IX_SuperheroSuperpowers_SuperpowerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperheroSuperpowers",
                table: "SuperheroSuperpowers",
                columns: new[] { "SuperheroId", "SuperpowerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SuperheroSuperpowers_Heroes_SuperheroId",
                table: "SuperheroSuperpowers",
                column: "SuperheroId",
                principalTable: "Heroes",
                principalColumn: "SuperheroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuperheroSuperpowers_Powers_SuperpowerId",
                table: "SuperheroSuperpowers",
                column: "SuperpowerId",
                principalTable: "Powers",
                principalColumn: "SuperpowerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
