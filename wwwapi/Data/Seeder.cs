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
            List<Ability> abilityList = new List<Ability>();
            for ( int i = 1; i <= 12; i++ )
            {
                abilityList.Add(new Ability()
                {
                    Id = i, 
                    Prof = i % 2 == 0, 
                    Value = i % 20,
                });
            }


            int numAbilities = 1;


            List<Abilities> abilities = new List<Abilities>();
            for ( int i = 1; i <= 2; i++ )
            {
                abilities.Add(new Abilities()
                {
                    Id = i,
                    StrengthID = numAbilities++,
                    DexterityId = numAbilities++,
                    ConstitutionId = numAbilities++,
                    IntelligenceId = numAbilities++,
                    WisdomId = numAbilities++,
                    CharismaId = numAbilities++,
                    CharacterId = i,
                });
            }

            modelBuilder.Entity<Ability>().HasData(abilityList);

            modelBuilder.Entity<Abilities>().HasData(abilities);
/*
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
            });*/
        }

        /*public static void SeedAbilitiesProf(ModelBuilder modelBuilder)
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
        }*/

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

        public static void SeedSkills(ModelBuilder modelBuilder)
        {

            List<Skills> skills = new List<Skills>();

            int numSkills = 1;

            for (int i = 1; i <= 2; i++)
            {
                skills.Add(new Skills()
                {
                    Id = i,
                    AcrobaticsId = numSkills++,
                    AnimalHandlingId = numSkills++,
                    ArcanaId = numSkills++,
                    AthleticsId = numSkills++,
                    DeceptionId = numSkills++,
                    HistoryId = numSkills++,
                    InsightId = numSkills++,
                    IntimidationId = numSkills++,
                    InvestigationId = numSkills++,
                    MedicineId = numSkills++,
                    NatureId = numSkills++,
                    PerceptionId = numSkills++,
                    PerformanceId = numSkills++,
                    PersuationId = numSkills++,
                    ReligionId = numSkills++,
                    SleightOfHandId = numSkills++,
                    StealthId = numSkills++,
                    SurvivalId = numSkills++,
                    CharacterId = i,
                });
            }

            List<Skill> skillList = new List<Skill>();

            for (int i = 1; i <= numSkills; i++)
            {
                skillList.Add(new Skill()
                {
                    Id = i,
                    Prof = i % 3 == 0,
                    Exp = i % 5 == 0
                });
            }

            modelBuilder.Entity<Skill>().HasData(skillList);

            modelBuilder.Entity<Skills>().HasData(skills);
        }
            /*modelBuilder.Entity<SkillsExp>().HasData(new List<SkillsExp>
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
        }*/

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
