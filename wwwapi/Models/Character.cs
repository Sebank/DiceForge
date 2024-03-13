using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    [Table("characters")]
    public class Character
    {
        [Column("id")]
        public int Id { get; set; }
    }
}
