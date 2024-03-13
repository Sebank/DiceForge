﻿using System.ComponentModel.DataAnnotations.Schema;

namespace wwwapi.Models
{
    [Table("ability")]
    public class Ability
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("value")]
        public int Value { get; set; }
        [Column("prof")]
        public bool Prof { get; set; }
    }
}
