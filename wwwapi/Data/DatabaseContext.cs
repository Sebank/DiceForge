using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using wwwapi.Models;

namespace wwwapi.Data
{
    public class DatabaseContext : DbContext
    {

        private string _connectionString;
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            //this.Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().Navigation(c => c.Abilities).AutoInclude();
            modelBuilder.Entity<Character>().Navigation(c => c.SkillsProf).AutoInclude();
            modelBuilder.Entity<Character>().Navigation(c => c.SkillsExp).AutoInclude();
            modelBuilder.Entity<Character>().Navigation(c => c.Speed).AutoInclude();
            modelBuilder.Entity<Character>().Navigation(c => c.Style).AutoInclude();

            modelBuilder.Entity<Abilities>().Navigation(a => a.Strength).AutoInclude();
            modelBuilder.Entity<Abilities>().Navigation(a => a.Constitution).AutoInclude();
            modelBuilder.Entity<Abilities>().Navigation(a => a.Dexterity).AutoInclude();
            modelBuilder.Entity<Abilities>().Navigation(a => a.Wisdom).AutoInclude();
            modelBuilder.Entity<Abilities>().Navigation(a => a.Intelligence).AutoInclude();
            modelBuilder.Entity<Abilities>().Navigation(a => a.Charisma).AutoInclude();


            Seeder.SeedCharacters(modelBuilder);
            Seeder.SeedAbilities(modelBuilder);
            Seeder.SeedStyle(modelBuilder);
            Seeder.SeedSpeed(modelBuilder);
            Seeder.SeedSkillsProf(modelBuilder);
            Seeder.SeedSkillsExp(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase(databaseName: "Database");
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console

        }
    }
}
