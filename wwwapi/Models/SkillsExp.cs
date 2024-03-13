using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    [Table("skills_exp")]
    public class SkillsExp
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("animal_handling")]
        public bool AnimalHandling { get; set; }
        [Column("arcana")]
        public bool Arcana { get; set; }
        [Column("athletics")]
        public bool Athletics { get; set; }
        [Column("deception")]
        public bool Deception { get; set; }
        [Column("history")]
        public bool History { get; set; }
        [Column("insight")]
        public bool Insight { get; set; }
        [Column("intimidation")]
        public bool Intimidation { get; set; }
        [Column("investigation")]
        public bool Investigation { get; set; }
        [Column("medicine")]
        public bool Medicine { get; set; }
        [Column("nature")]
        public bool Nature { get; set; }
        [Column("perception")]
        public bool Perception { get; set; }
        [Column("persuation")]
        public bool Persuation { get; set; }
        [Column("religion")]
        public bool Religion { get; set; }
        [Column("sleight_of_hand")]
        public bool SleightOfHand { get; set; }
        [Column("stealth")]
        public bool Stealth { get; set; }
        [Column("survival")]
        public bool Survival { get; set; }
        [Column("character_id"), ForeignKey("Character")]
        public int CharacterId { get; set; }
    }
}
