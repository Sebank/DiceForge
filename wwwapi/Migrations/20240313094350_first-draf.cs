using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wwwapi.Migrations
{
    /// <inheritdoc />
    public partial class firstdraf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AbilityScoreProf",
                columns: new[] { "id", "character_id", "charisma", "constitution", "dexterity", "intelligence", "strength", "wisdom" },
                values: new object[,]
                {
                    { 1, 2, false, false, false, false, false, true },
                    { 2, 1, false, true, false, false, false, false }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AbilityScoreProf",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AbilityScoreProf",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "skills_exp",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "skills_exp",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "skills_prof",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "skills_prof",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "speed",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "speed",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
