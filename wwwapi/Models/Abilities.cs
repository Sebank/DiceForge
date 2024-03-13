using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    [Table("abilities")]
    public class Abilities
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("strength_id"), ForeignKey("Ability")]
        public int StrengthID { get; set; }
        [Column("strength")]
        public Ability Strength { get; set; }
        [Column("dexterity_id"), ForeignKey("Ability")]
        public int DexterityId { get; set; }
        [Column("dexterity")]
        public Ability Dexterity { get; set; }
        [Column("constitution_id"), ForeignKey("Ability")]
        public int ConstitutionId { get; set; }
        [Column("constitution")]
        public Ability Constitution { get; set; }
        [Column("intelligence_id"), ForeignKey("Ability")]
        public int IntelligenceId { get; set; }
        [Column("intelligence")]
        public Ability Intelligence { get; set; }
        [Column("wisdom_id"), ForeignKey("Ability")]
        public int WisdomId { get; set; }
        [Column("wisdom")]
        public Ability Wisdom { get; set; }
        [Column("charisma_id"), ForeignKey("Ability")]
        public int CharismaId { get; set; }
        [Column("charisma")]
        public Ability Charisma { get; set; }
        [Column("character_id"), ForeignKey("Character")]
        public int CharacterId { get; set; }
    }
}
