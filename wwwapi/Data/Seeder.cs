using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using wwwapi.Models;

namespace wwwapi.Data
{
    public static class Seeder
    {

        public static void SeedCharacters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(new List<Character>{
                new Character()
                {
                    Id = 1
                }, 
                new Character()
                {
                    Id = 2
                }
            });
        }

        public static void SeedAbilities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbilityScores>().HasData(new List<AbilityScores>{
                new AbilityScores()
                {
                    Id = 1,
                    Strength = 1,
                    Dexterity = 2,
                    Constitution = 3,
                    Intelligence = 4,
                    Wisdom = 5,
                    Charisma = 6,
                    CharacterId = 1
                },
                new AbilityScores()
                {
                    Id = 2,
                    Strength = 6,
                    Dexterity = 2,
                    Constitution = 5,
                    Intelligence = 4,
                    Wisdom = 5,
                    Charisma = 6,
                    CharacterId = 2
                }
            });
        }

        public static void SeedAbilitiesProf(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbilityScoreProf>().HasData(new List<AbilityScoreProf>
            {
                new AbilityScoreProf()
                {
                    Id = 1, 
                    Strength = false, 
                    Dexterity = false, 
                    Constitution = false, 
                    Intelligence = false, 
                    Wisdom = true,
                    Charisma = false,
                    CharacterId = 2
                },
                new AbilityScoreProf()
                {
                    Id = 2,
                    Strength = false,
                    Dexterity = false,
                    Constitution = true,
                    Intelligence = false,
                    Wisdom = false,
                    Charisma = false,
                    CharacterId = 1
                }
            });
        }

        public static void SeedStyle(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Style>().HasData(new List<Style>
            {
                new Style()
                {
                    Id = 1,
                    Name = "Name",
                    Description = "Description",
                    Age = 21, 
                    Height = "2'11", 
                    Width = "2'6",
                    Eyes = "Blue", 
                    Hair = "Not blue", 
                    Skin = "Blue", 
                    Race = "No", 
                    Class_ = Class_.Wizard, 
                    Alignment = Alignment.Neutral, 
                    Background = Background.Criminal,

                    CharacterId = 1
                },
                new Style()
                {
                    Id = 2,
                    Name = "Other Name",
                    Description = "Other Description",
                    Age = 22,
                    Height = "4'11",
                    Width = "1'6",
                    Eyes = "Other Blue",
                    Hair = "Other Not blue",
                    Skin = "Other Blue",
                    Race = "Other No",
                    Class_ = Class_.Paladin,
                    Alignment = Alignment.LawfulEvil,
                    Background = Background.Charlatan,

                    CharacterId = 2
                }
            });
        }

        public static void SeedSkillsExp(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillsExp>().HasData(new List<SkillsExp>
            {
                new SkillsExp() {
                    Id = 1,
                    AnimalHandling = false,
                    Arcana = false,
                    Athletics = true,
                    Deception = false,
                    History = false,
                    Insight = false,
                    Intimidation = true,
                    Investigation = false,
                    Medicine = false,
                    Nature = false,
                    Perception = false,
                    Persuation = false,
                    Religion = true,
                    SleightOfHand = false,
                    Stealth = false,
                    Survival = false,
                    CharacterId = 2
                },
                new SkillsExp() {
                    Id = 2,
                    AnimalHandling = false,
                    Arcana = false,
                    Athletics = false,
                    Deception = false,
                    History = true,
                    Insight = false,
                    Intimidation = false,
                    Investigation = false,
                    Medicine = true,
                    Nature = false,
                    Perception = false,
                    Persuation = false,
                    Religion = true,
                    SleightOfHand = false,
                    Stealth = false,
                    Survival = false,
                    CharacterId = 1
                },
            });
        }

        public static void SeedSkillsProf(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillsProf>().HasData(new List<SkillsProf>
            {
                new SkillsProf() {
                    Id = 1,
                    AnimalHandling = false,
                    Arcana = false,
                    Athletics = true,
                    Deception = false,
                    History = false,
                    Insight = false,
                    Intimidation = false,
                    Investigation = false,
                    Medicine = false,
                    Nature = false,
                    Perception = false,
                    Persuation = false,
                    Religion = true,
                    SleightOfHand = true,
                    Stealth = false,
                    Survival = false,
                    CharacterId = 2
                },
                new SkillsProf() {
                    Id = 2,
                    AnimalHandling = false,
                    Arcana = false,
                    Athletics = false,
                    Deception = false,
                    History = false,
                    Insight = false,
                    Intimidation = true,
                    Investigation = false,
                    Medicine = true,
                    Nature = false,
                    Perception = false,
                    Persuation = false,
                    Religion = true,
                    SleightOfHand = false,
                    Stealth = false,
                    Survival = false,
                    CharacterId = 1
                },
            });
        }

        public static void SeedSpeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speed>().HasData(new List<Speed> { 
                new Speed()
                {
                    Id = 1, 
                    Value = 30, 
                    CharacterId = 1
                }, 
                new Speed()
                {
                    Id = 2, 
                    Value = 35, 
                    CharacterId = 2
                }
            });
        }
    }
}
