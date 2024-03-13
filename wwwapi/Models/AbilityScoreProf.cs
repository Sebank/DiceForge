using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    public class AbilityScoreProf
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("strength")]
        public bool Strength { get; set; }
        [Column("dexterity")]
        public bool Dexterity { get; set; }
        [Column("constitution")]
        public bool Constitution { get; set; }
        [Column("intelligence")]
        public bool Intelligence { get; set; }
        [Column("wisdom")]
        public bool Wisdom { get; set; }
        [Column("charisma")]
        public bool Charisma { get; set; }
        [Column("character_id"), ForeignKey("Character")]
        public int CharacterId { get; set; }
    }
}
