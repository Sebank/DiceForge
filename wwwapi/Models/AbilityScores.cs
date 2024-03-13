using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    [Table("ability_scores")]
    public class AbilityScores
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("strength")]
        public int Strength { get; set; }
        [Column("dexterity")]
        public int Dexterity { get; set; }
        [Column("constitution")]
        public int Constitution { get; set; }
        [Column("intelligence")]
        public int Intelligence { get; set; }
        [Column("wisdom")]
        public int Wisdom { get; set; }
        [Column("charisma")]
        public int Charisma { get; set; }
        [Column("character_id"), ForeignKey("Character")]
        public int CharacterId { get; set; }
    }
}
