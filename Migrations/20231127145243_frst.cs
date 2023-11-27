using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperheroDB.Migrations
{
    /// <inheritdoc />
    public partial class frst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    SuperheroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecretIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.SuperheroId);
                });

            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    SuperpowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powers", x => x.SuperpowerId);
                });

            migrationBuilder.CreateTable(
                name: "SuperheroSuperpowers",
                columns: table => new
                {
                    SuperheroId = table.Column<int>(type: "int", nullable: false),
                    SuperpowerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperheroSuperpowers", x => new { x.SuperheroId, x.SuperpowerId });
                    table.ForeignKey(
                        name: "FK_SuperheroSuperpowers_Heroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Heroes",
                        principalColumn: "SuperheroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuperheroSuperpowers_Powers_SuperpowerId",
                        column: x => x.SuperpowerId,
                        principalTable: "Powers",
                        principalColumn: "SuperpowerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "SuperheroId", "ImageUrl", "Name", "SecretIdentity" },
                values: new object[,]
                {
                    { 1, "Images/wonderwoman.jpg", "Wonder Woman", "Diana Prince" },
                    { 2, "Images/superman.jpg", "Superman", "Clark Kent" }
                });

            migrationBuilder.InsertData(
                table: "Powers",
                columns: new[] { "SuperpowerId", "Name" },
                values: new object[,]
                {
                    { 1, "Super Strength" },
                    { 2, "Flight" },
                    { 3, "Telekinesis" }
                });

            migrationBuilder.InsertData(
                table: "SuperheroSuperpowers",
                columns: new[] { "SuperheroId", "SuperpowerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuperheroSuperpowers_SuperpowerId",
                table: "SuperheroSuperpowers",
                column: "SuperpowerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperheroSuperpowers");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Powers");
        }
    }
}
