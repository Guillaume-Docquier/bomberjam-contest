﻿// <auto-generated />
using System;
using Bomberjam.Website.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bomberjam.Website.Migrations
{
    [DbContext(typeof(BomberjamContext))]
    [Migration("20210215075138_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Bomberjam.Website.Database.DbGame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Errors")
                        .HasColumnType("TEXT");

                    b.Property<double?>("GameDuration")
                        .HasColumnType("REAL");

                    b.Property<double?>("InitDuration")
                        .HasColumnType("REAL");

                    b.Property<string>("Stderr")
                        .HasColumnType("TEXT");

                    b.Property<string>("Stdout")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("App_Games");
                });

            modelBuilder.Entity("Bomberjam.Website.Database.DbGameUser", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<float>("DeltaPoints")
                        .HasColumnType("REAL");

                    b.Property<string>("Errors")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("GameId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("App_GameUsers");
                });

            modelBuilder.Entity("Bomberjam.Website.Database.DbQueuedTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Created");

                    b.HasIndex("Status");

                    b.HasIndex("Type");

                    b.HasIndex("UserId");

                    b.ToTable("App_Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f7ac849d-d059-4286-a56a-ab25e144db7e"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(6157),
                            Data = "00000000-0000-0000-0000-000000000001",
                            Status = 1,
                            Type = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(6339),
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("89a22c17-0406-4b80-9c7f-d5f657f71392"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7545),
                            Data = "00000000-0000-0000-0000-000000000002",
                            Status = 1,
                            Type = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7547),
                            UserId = new Guid("00000000-0000-0000-0000-000000000002")
                        },
                        new
                        {
                            Id = new Guid("d578c9e7-a796-4982-ab50-16ddf9cd936d"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7551),
                            Data = "00000000-0000-0000-0000-000000000003",
                            Status = 1,
                            Type = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7552),
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("94990982-86ba-4be3-b62a-985475ee2813"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7555),
                            Data = "00000000-0000-0000-0000-000000000004",
                            Status = 1,
                            Type = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7555),
                            UserId = new Guid("00000000-0000-0000-0000-000000000004")
                        },
                        new
                        {
                            Id = new Guid("9c7599f5-d1fc-4815-bdb3-379c6cd6f3bf"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7558),
                            Data = "00000000-0000-0000-0000-000000000005",
                            Status = 1,
                            Type = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7559),
                            UserId = new Guid("00000000-0000-0000-0000-000000000005")
                        },
                        new
                        {
                            Id = new Guid("84546e20-5b80-4e5d-881d-1fae354da207"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7561),
                            Data = "00000000-0000-0000-0000-000000000006",
                            Status = 1,
                            Type = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7562),
                            UserId = new Guid("00000000-0000-0000-0000-000000000006")
                        },
                        new
                        {
                            Id = new Guid("22b810ad-2cf3-4c76-8651-078921a1cfdf"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7564),
                            Data = "00000000-0000-0000-0000-000000000007",
                            Status = 1,
                            Type = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 986, DateTimeKind.Utc).AddTicks(7565),
                            UserId = new Guid("00000000-0000-0000-0000-000000000007")
                        },
                        new
                        {
                            Id = new Guid("ebd0d6cd-af5d-455a-9b06-bd754f89d158"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 987, DateTimeKind.Utc).AddTicks(1960),
                            Data = "00000000-0000-0000-0000-000000000002:Falgar,00000000-0000-0000-0000-000000000004:Minty,00000000-0000-0000-0000-000000000007:Mire,00000000-0000-0000-0000-000000000003:Xenure",
                            Status = 1,
                            Type = 2,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 987, DateTimeKind.Utc).AddTicks(1963)
                        },
                        new
                        {
                            Id = new Guid("2c474ca3-3730-4b10-b33a-20a83d3ad20f"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 987, DateTimeKind.Utc).AddTicks(3743),
                            Data = "00000000-0000-0000-0000-000000000004:Minty,00000000-0000-0000-0000-000000000007:Mire,00000000-0000-0000-0000-000000000006:Pandarf,00000000-0000-0000-0000-000000000005:Kalmera",
                            Status = 1,
                            Type = 2,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 987, DateTimeKind.Utc).AddTicks(3746)
                        },
                        new
                        {
                            Id = new Guid("6e8ea553-b695-4e21-aeae-4b681c5c8384"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 987, DateTimeKind.Utc).AddTicks(3816),
                            Data = "00000000-0000-0000-0000-000000000006:Pandarf,00000000-0000-0000-0000-000000000004:Minty,00000000-0000-0000-0000-000000000001:Askaiser,00000000-0000-0000-0000-000000000002:Falgar",
                            Status = 1,
                            Type = 2,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 987, DateTimeKind.Utc).AddTicks(3816)
                        },
                        new
                        {
                            Id = new Guid("ea140403-0167-44f2-a93a-e9d02b719013"),
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 987, DateTimeKind.Utc).AddTicks(3851),
                            Data = "00000000-0000-0000-0000-000000000001:Askaiser,00000000-0000-0000-0000-000000000003:Xenure,00000000-0000-0000-0000-000000000005:Kalmera,00000000-0000-0000-0000-000000000006:Pandarf",
                            Status = 1,
                            Type = 2,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 987, DateTimeKind.Utc).AddTicks(3852)
                        });
                });

            modelBuilder.Entity("Bomberjam.Website.Database.DbUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BotLanguage")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompilationErrors")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GithubId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompiled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompiling")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Points")
                        .HasColumnType("REAL");

                    b.Property<int>("SubmitCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("GithubId")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("App_Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            BotLanguage = "",
                            CompilationErrors = "",
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(5698),
                            Email = "simmon.anthony@gmail.com",
                            GameCount = 0,
                            GithubId = 14242083,
                            IsCompiled = false,
                            IsCompiling = false,
                            Points = 1500f,
                            SubmitCount = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(5869),
                            UserName = "Askaiser"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            BotLanguage = "",
                            CompilationErrors = "",
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7160),
                            Email = "falgar@gmail.com",
                            GameCount = 0,
                            GithubId = 36072624,
                            IsCompiled = false,
                            IsCompiling = false,
                            Points = 1500f,
                            SubmitCount = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7163),
                            UserName = "Falgar"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            BotLanguage = "",
                            CompilationErrors = "",
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7165),
                            Email = "xenure@gmail.com",
                            GameCount = 0,
                            GithubId = 9208753,
                            IsCompiled = false,
                            IsCompiling = false,
                            Points = 1500f,
                            SubmitCount = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7166),
                            UserName = "Xenure"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            BotLanguage = "",
                            CompilationErrors = "",
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7167),
                            Email = "minty@gmail.com",
                            GameCount = 0,
                            GithubId = 26142591,
                            IsCompiled = false,
                            IsCompiling = false,
                            Points = 1500f,
                            SubmitCount = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7168),
                            UserName = "Minty"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            BotLanguage = "",
                            CompilationErrors = "",
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7169),
                            Email = "kalmera@gmail.com",
                            GameCount = 0,
                            GithubId = 5122918,
                            IsCompiled = false,
                            IsCompiling = false,
                            Points = 1500f,
                            SubmitCount = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7170),
                            UserName = "Kalmera"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            BotLanguage = "",
                            CompilationErrors = "",
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7171),
                            Email = "pandarf@gmail.com",
                            GameCount = 0,
                            GithubId = 1035273,
                            IsCompiled = false,
                            IsCompiling = false,
                            Points = 1500f,
                            SubmitCount = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7172),
                            UserName = "Pandarf"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            BotLanguage = "",
                            CompilationErrors = "",
                            Created = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7174),
                            Email = "mire@gmail.com",
                            GameCount = 0,
                            GithubId = 5489330,
                            IsCompiled = false,
                            IsCompiling = false,
                            Points = 1500f,
                            SubmitCount = 1,
                            Updated = new DateTime(2021, 2, 15, 7, 51, 37, 985, DateTimeKind.Utc).AddTicks(7174),
                            UserName = "Mire"
                        });
                });

            modelBuilder.Entity("Bomberjam.Website.Database.DbGameUser", b =>
                {
                    b.HasOne("Bomberjam.Website.Database.DbGame", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bomberjam.Website.Database.DbUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bomberjam.Website.Database.DbQueuedTask", b =>
                {
                    b.HasOne("Bomberjam.Website.Database.DbUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}