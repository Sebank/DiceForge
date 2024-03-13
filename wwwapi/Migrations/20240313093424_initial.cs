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
                name: "AbilityScoreProf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    strength = table.Column<bool>(type: "boolean", nullable: false),
                    dexterity = table.Column<bool>(type: "boolean", nullable: false),
                    constitution = table.Column<bool>(type: "boolean", nullable: false),
                    intelligence = table.Column<bool>(type: "boolean", nullable: false),
                    wisdom = table.Column<bool>(type: "boolean", nullable: false),
                    charisma = table.Column<bool>(type: "boolean", nullable: false),
                    character_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScoreProf", x => x.id);
                    table.ForeignKey(
                        name: "FK_AbilityScoreProf_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_ability_scores_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skills_exp",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    animal_handling = table.Column<bool>(type: "boolean", nullable: false),
                    arcana = table.Column<bool>(type: "boolean", nullable: false),
                    athletics = table.Column<bool>(type: "boolean", nullable: false),
                    deception = table.Column<bool>(type: "boolean", nullable: false),
                    history = table.Column<bool>(type: "boolean", nullable: false),
                    insight = table.Column<bool>(type: "boolean", nullable: false),
                    intimidation = table.Column<bool>(type: "boolean", nullable: false),
                    investigation = table.Column<bool>(type: "boolean", nullable: false),
                    medicine = table.Column<bool>(type: "boolean", nullable: false),
                    nature = table.Column<bool>(type: "boolean", nullable: false),
                    perception = table.Column<bool>(type: "boolean", nullable: false),
                    persuation = table.Column<bool>(type: "boolean", nullable: false),
                    religion = table.Column<bool>(type: "boolean", nullable: false),
                    sleight_of_hand = table.Column<bool>(type: "boolean", nullable: false),
                    stealth = table.Column<bool>(type: "boolean", nullable: false),
                    survival = table.Column<bool>(type: "boolean", nullable: false),
                    character_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills_exp", x => x.id);
                    table.ForeignKey(
                        name: "FK_skills_exp_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skills_prof",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    animal_handling = table.Column<bool>(type: "boolean", nullable: false),
                    arcana = table.Column<bool>(type: "boolean", nullable: false),
                    athletics = table.Column<bool>(type: "boolean", nullable: false),
                    deception = table.Column<bool>(type: "boolean", nullable: false),
                    history = table.Column<bool>(type: "boolean", nullable: false),
                    insight = table.Column<bool>(type: "boolean", nullable: false),
                    intimidation = table.Column<bool>(type: "boolean", nullable: false),
                    investigation = table.Column<bool>(type: "boolean", nullable: false),
                    medicine = table.Column<bool>(type: "boolean", nullable: false),
                    nature = table.Column<bool>(type: "boolean", nullable: false),
                    perception = table.Column<bool>(type: "boolean", nullable: false),
                    persuation = table.Column<bool>(type: "boolean", nullable: false),
                    religion = table.Column<bool>(type: "boolean", nullable: false),
                    sleight_of_hand = table.Column<bool>(type: "boolean", nullable: false),
                    stealth = table.Column<bool>(type: "boolean", nullable: false),
                    survival = table.Column<bool>(type: "boolean", nullable: false),
                    character_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills_prof", x => x.id);
                    table.ForeignKey(
                        name: "FK_skills_prof_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "speed",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<int>(type: "integer", nullable: false),
                    character_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speed", x => x.id);
                    table.ForeignKey(
                        name: "FK_speed_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_styles_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "ability_scores",
                columns: new[] { "id", "character_id", "charisma", "constitution", "dexterity", "intelligence", "strength", "wisdom" },
                values: new object[,]
                {
                    { 1, 1, 6, 3, 2, 4, 1, 5 },
                    { 2, 2, 6, 5, 2, 4, 6, 5 }
                });

            migrationBuilder.InsertData(
                table: "styles",
                columns: new[] { "id", "age", "alignment", "background", "character_id", "class", "description", "eyes", "hair", "height", "name", "race", "skin", "width" },
                values: new object[,]
                {
                    { 1, 21, 4, 2, 1, 11, "Description", "Blue", "Not blue", "2'11", "Name", "No", "Blue", "2'6" },
                    { 2, 22, 6, 1, 2, 6, "Other Description", "Other Blue", "Other Not blue", "4'11", "Other Name", "Other No", "Other Blue", "1'6" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScoreProf_character_id",
                table: "AbilityScoreProf",
                column: "character_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ability_scores_character_id",
                table: "ability_scores",
                column: "character_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_skills_exp_character_id",
                table: "skills_exp",
                column: "character_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_skills_prof_character_id",
                table: "skills_prof",
                column: "character_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_speed_character_id",
                table: "speed",
                column: "character_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_styles_character_id",
                table: "styles",
                column: "character_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityScoreProf");

            migrationBuilder.DropTable(
                name: "ability_scores");

            migrationBuilder.DropTable(
                name: "skills_exp");

            migrationBuilder.DropTable(
                name: "skills_prof");

            migrationBuilder.DropTable(
                name: "speed");

            migrationBuilder.DropTable(
                name: "styles");

            migrationBuilder.DropTable(
                name: "characters");
        }
    }
}
