﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using wwwapi.Data;

#nullable disable

namespace wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240312200219_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("wwwapi.Models.AbilityScores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer")
                        .HasColumnName("character_id");

                    b.Property<int>("Charisma")
                        .HasColumnType("integer")
                        .HasColumnName("charisma");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer")
                        .HasColumnName("constitution");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer")
                        .HasColumnName("dexterity");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer")
                        .HasColumnName("intelligence");

                    b.Property<int>("Strength")
                        .HasColumnType("integer")
                        .HasColumnName("strength");

                    b.Property<int>("Wisdom")
                        .HasColumnType("integer")
                        .HasColumnName("wisdom");

                    b.HasKey("Id");

                    b.ToTable("ability_scores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Charisma = 6,
                            Constitution = 3,
                            Dexterity = 2,
                            Intelligence = 4,
                            Strength = 1,
                            Wisdom = 5
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Charisma = 6,
                            Constitution = 5,
                            Dexterity = 2,
                            Intelligence = 4,
                            Strength = 6,
                            Wisdom = 5
                        });
                });

            modelBuilder.Entity("wwwapi.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("characters");

                    b.HasData(
                        new
                        {
                            Id = 1
                        },
                        new
                        {
                            Id = 2
                        });
                });

            modelBuilder.Entity("wwwapi.Models.Style", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<int>("Alignment")
                        .HasColumnType("integer")
                        .HasColumnName("alignment");

                    b.Property<int>("Background")
                        .HasColumnType("integer")
                        .HasColumnName("background");

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer")
                        .HasColumnName("character_id");

                    b.Property<int>("Class_")
                        .HasColumnType("integer")
                        .HasColumnName("class");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Eyes")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("eyes");

                    b.Property<string>("Hair")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("hair");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("height");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("race");

                    b.Property<string>("Skin")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("skin");

                    b.Property<string>("Width")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("width");

                    b.HasKey("Id");

                    b.ToTable("styles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 21,
                            Alignment = 4,
                            Background = 2,
                            CharacterId = 1,
                            Class_ = 11,
                            Description = "Description",
                            Eyes = "Blue",
                            Hair = "Not blue",
                            Height = "2'11",
                            Name = "Name",
                            Race = "No",
                            Skin = "Blue",
                            Width = "2'6"
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Alignment = 6,
                            Background = 1,
                            CharacterId = 2,
                            Class_ = 6,
                            Description = "Other Description",
                            Eyes = "Other Blue",
                            Hair = "Other Not blue",
                            Height = "4'11",
                            Name = "Other Name",
                            Race = "Other No",
                            Skin = "Other Blue",
                            Width = "1'6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}