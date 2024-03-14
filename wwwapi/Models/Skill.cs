using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    [Table("skill")]
    public class Skill
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("prof")]
        public bool Prof { get; set; }
        [Column("exp")]
        public bool Exp { get; set; }
    }
}
