using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    [Table("speed")]
    public class Speed
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("value")]
        public int Value { get; set; }
        [Column("character_id"), ForeignKey("Character")]
        public int CharacterId { get; set; }
    }
}
