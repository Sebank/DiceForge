using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wwwapi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ability_scores",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    strength = table.Column<int>(type: "integer", nullable: false),
                    dexterity = table.Column<int>(type: "integer", nullable: false),
                    constitution = table.Column<int>(type: "integer", nullable: false),
                    intelligence = table.Column<int>(type: "integer", nullable: false),
                    wisdom = table.Column<int>(type: "integer", nullable: false),
                    charisma = table.Column<int>(type: "integer", nullable: false),
                    character_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ability_scores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "styles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    age = table.Column<int>(type: "integer", nullable: false),
                    height = table.Column<string>(type: "text", nullable: false),
                    width = table.Column<string>(type: "text", nullable: false),
                    eyes = table.Column<string>(type: "text", nullable: false),
                    hair = table.Column<string>(type: "text", nullable: false),
                    skin = table.Column<string>(type: "text", nullable: false),
                    race = table.Column<string>(type: "text", nullable: false),
                    @class = table.Column<int>(name: "class", type: "integer", nullable: false),
                    alignment = table.Column<int>(type: "integer", nullable: false),
                    background = table.Column<int>(type: "integer", nullable: false),
                    character_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_styles", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "ability_scores",
                columns: new[] { "id", "character_id", "charisma", "constitution", "dexterity", "intelligence", "strength", "wisdom" },
                values: new object[,]
                {
                    { 1, 1, 6, 3, 2, 4, 1, 5 },
                    { 2, 2, 6, 5, 2, 4, 6, 5 }
                });

            migrationBuilder.InsertData(
                table: "characters",
                column: "id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "styles",
                columns: new[] { "id", "age", "alignment", "background", "character_id", "class", "description", "eyes", "hair", "height", "name", "race", "skin", "width" },
                values: new object[,]
                {
                    { 1, 21, 4, 2, 1, 11, "Description", "Blue", "Not blue", "2'11", "Name", "No", "Blue", "2'6" },
                    { 2, 22, 6, 1, 2, 6, "Other Description", "Other Blue", "Other Not blue", "4'11", "Other Name", "Other No", "Other Blue", "1'6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ability_scores");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "styles");
        }
    }
}
