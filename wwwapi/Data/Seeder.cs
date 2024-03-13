using Microsoft.EntityFrameworkCore;
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
    }
}
