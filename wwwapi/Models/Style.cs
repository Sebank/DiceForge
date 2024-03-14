﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace wwwapi.Models
{
    [Table("styles")]
    public class Style
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("height")]
        public string Height { get; set; }
        [Column("width")]
        public string Width { get; set; }
        [Column("eyes")]
        public string Eyes { get; set; }
        [Column("hair")]
        public string Hair { get; set; }
        [Column("skin")]
        public string Skin { get; set; }
        [Column("race")]
        public string Race { get; set; }
        [Column("class")]
        public Class_ Class_ { get; set; }
        [Column("alignment")]
        public Alignment Alignment { get; set; }
        [Column("background")]
        public Background Background { get; set; }
        [Column("character_id"), ForeignKey("Character"), JsonIgnore]
        public int CharacterId { get; set; }
    }

    public enum Class_
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rouge,
        Sourcerer,
        Warlock,
        Wizard,
        Artificer,
        BloodHunter
    }

    public enum Alignment
    {
        LawfulGood,
        NeutralGood,
        ChaoticGood,
        LawfullNeutral,
        Neutral,
        ChaoticNeutral,
        LawfulEvil,
        NeutralEvil,
        ChaoticEvil
    }
    public enum Background
    {
        Acolyte,
        Charlatan,
        Criminal,
        Entertainer,
        FolkHero,
        GuildArtisian,
        Hermit,
        Noble,
        Outlander,
        Sage,
        Sailor,
        Soldier,
        Urchin
    }
}
