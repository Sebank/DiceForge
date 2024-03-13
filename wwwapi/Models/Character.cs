using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    [Table("characters")]
    public class Character
    {
        [Column("id")]
        public int Id { get; set; }
        public Style Style { get; set; }
        public AbilityScores Score { get; set; }
        public AbilityScoreProf ScoreProf { get; set; }
        public SkillsProf SkillsProf { get; set; }
        public SkillsExp SkillsExp { get; set; }
        public Speed Speed { get; set; }
    }
}
