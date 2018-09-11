﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Samurai1;

namespace Samurai1.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    [Migration("20180911083855_xx")]
    partial class xx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Samurai1.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Brutal");

                    b.Property<string>("Description");

                    b.Property<DateTime>("WarEnd");

                    b.Property<DateTime>("WarStart");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("Samurai1.BattleLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BattleId");

                    b.Property<string>("Log");

                    b.HasKey("Id");

                    b.HasIndex("BattleId")
                        .IsUnique();

                    b.ToTable("BattleLogs");
                });

            modelBuilder.Entity("Samurai1.HairStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SamuraiId");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("HairStyles");
                });

            modelBuilder.Entity("Samurai1.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SamuraiId");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("Samurai1.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("Samurai1.SamuraiBattle", b =>
                {
                    b.Property<int>("BattleId");

                    b.Property<int>("SamuraiId");

                    b.HasKey("BattleId", "SamuraiId");

                    b.HasIndex("SamuraiId");

                    b.ToTable("SamuraiBattles");
                });

            modelBuilder.Entity("Samurai1.SecretIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SamuraiId");

                    b.Property<string>("SecretName");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId")
                        .IsUnique();

                    b.ToTable("SecretIdentities");
                });

            modelBuilder.Entity("Samurai1.BattleLog", b =>
                {
                    b.HasOne("Samurai1.Battle", "Battle")
                        .WithOne("BattleLogId")
                        .HasForeignKey("Samurai1.BattleLog", "BattleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Samurai1.HairStyle", b =>
                {
                    b.HasOne("Samurai1.Samurai", "Samurai")
                        .WithMany()
                        .HasForeignKey("SamuraiId");
                });

            modelBuilder.Entity("Samurai1.Quote", b =>
                {
                    b.HasOne("Samurai1.Samurai", "Samurai")
                        .WithMany()
                        .HasForeignKey("SamuraiId");
                });

            modelBuilder.Entity("Samurai1.SamuraiBattle", b =>
                {
                    b.HasOne("Samurai1.Battle", "Battle")
                        .WithMany()
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Samurai1.Samurai", "Samurai")
                        .WithMany()
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Samurai1.SecretIdentity", b =>
                {
                    b.HasOne("Samurai1.Samurai", "Samurai")
                        .WithOne("SecretIdentityId")
                        .HasForeignKey("Samurai1.SecretIdentity", "SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
