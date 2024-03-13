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
                name: "ability",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<int>(type: "integer", nullable: false),
                    prof = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ability", x => x.id);
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
                name: "abilities",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    strength_id = table.Column<int>(type: "integer", nullable: false),
                    dexterity_id = table.Column<int>(type: "integer", nullable: false),
                    constitution_id = table.Column<int>(type: "integer", nullable: false),
                    intelligence_id = table.Column<int>(type: "integer", nullable: false),
                    wisdom_id = table.Column<int>(type: "integer", nullable: false),
                    charisma_id = table.Column<int>(type: "integer", nullable: false),
                    character_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abilities", x => x.id);
                    table.ForeignKey(
                        name: "FK_abilities_ability_charisma_id",
                        column: x => x.charisma_id,
                        principalTable: "ability",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_abilities_ability_constitution_id",
                        column: x => x.constitution_id,
                        principalTable: "ability",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_abilities_ability_dexterity_id",
                        column: x => x.dexterity_id,
                        principalTable: "ability",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_abilities_ability_intelligence_id",
                        column: x => x.intelligence_id,
                        principalTable: "ability",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_abilities_ability_strength_id",
                        column: x => x.strength_id,
                        principalTable: "ability",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_abilities_ability_wisdom_id",
                        column: x => x.wisdom_id,
                        principalTable: "ability",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_abilities_characters_character_id",
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
                table: "ability",
                columns: new[] { "id", "prof", "value" },
                values: new object[,]
                {
                    { 1, false, 1 },
                    { 2, true, 2 },
                    { 3, false, 3 },
                    { 4, true, 4 },
                    { 5, false, 5 },
                    { 6, true, 6 },
                    { 7, false, 7 },
                    { 8, true, 8 },
                    { 9, false, 9 },
                    { 10, true, 10 },
                    { 11, false, 11 },
                    { 12, true, 12 }
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
                table: "abilities",
                columns: new[] { "id", "character_id", "charisma_id", "constitution_id", "dexterity_id", "intelligence_id", "strength_id", "wisdom_id" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, 3, 5, 4, 6 },
                    { 2, 2, 7, 8, 9, 11, 10, 12 }
                });

            migrationBuilder.InsertData(
                table: "skills_exp",
                columns: new[] { "id", "animal_handling", "arcana", "athletics", "character_id", "deception", "history", "insight", "intimidation", "investigation", "medicine", "nature", "perception", "persuation", "religion", "sleight_of_hand", "stealth", "survival" },
                values: new object[,]
                {
                    { 1, false, false, true, 2, false, false, false, true, false, false, false, false, false, true, false, false, false },
                    { 2, false, false, false, 1, false, true, false, false, false, true, false, false, false, true, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "skills_prof",
                columns: new[] { "id", "animal_handling", "arcana", "athletics", "character_id", "deception", "history", "insight", "intimidation", "investigation", "medicine", "nature", "perception", "persuation", "religion", "sleight_of_hand", "stealth", "survival" },
                values: new object[,]
                {
                    { 1, false, false, true, 2, false, false, false, false, false, false, false, false, false, true, true, false, false },
                    { 2, false, false, false, 1, false, false, false, true, false, true, false, false, false, true, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "speed",
                columns: new[] { "id", "character_id", "value" },
                values: new object[,]
                {
                    { 1, 1, 30 },
                    { 2, 2, 35 }
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
                name: "IX_abilities_character_id",
                table: "abilities",
                column: "character_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_abilities_charisma_id",
                table: "abilities",
                column: "charisma_id");

            migrationBuilder.CreateIndex(
                name: "IX_abilities_constitution_id",
                table: "abilities",
                column: "constitution_id");

            migrationBuilder.CreateIndex(
                name: "IX_abilities_dexterity_id",
                table: "abilities",
                column: "dexterity_id");

            migrationBuilder.CreateIndex(
                name: "IX_abilities_intelligence_id",
                table: "abilities",
                column: "intelligence_id");

            migrationBuilder.CreateIndex(
                name: "IX_abilities_strength_id",
                table: "abilities",
                column: "strength_id");

            migrationBuilder.CreateIndex(
                name: "IX_abilities_wisdom_id",
                table: "abilities",
                column: "wisdom_id");

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
                name: "abilities");

            migrationBuilder.DropTable(
                name: "skills_exp");

            migrationBuilder.DropTable(
                name: "skills_prof");

            migrationBuilder.DropTable(
                name: "speed");

            migrationBuilder.DropTable(
                name: "styles");

            migrationBuilder.DropTable(
                name: "ability");

            migrationBuilder.DropTable(
                name: "characters");
        }
    }
}
