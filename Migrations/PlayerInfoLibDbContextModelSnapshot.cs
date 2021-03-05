﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pustalorc.PlayerInfoLib.Unturned.Database;

namespace Pustalorc.PlayerInfoLib.Unturned.Migrations
{
    [DbContext(typeof(PlayerInfoLibDbContext))]
    partial class PlayerInfoLibDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pustalorc.PlayerInfoLib.Unturned.API.Classes.PlayerData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Hwid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Ip")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastLoginGlobal")
                        .HasColumnType("datetime");

                    b.Property<string>("LastQuestGroupId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProfilePictureHash")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<int>("ServerId")
                        .HasColumnType("int");

                    b.Property<string>("SteamGroup")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SteamGroupName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("SteamName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<double>("TotalPlaytime")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("Pustalorc_PlayerInfoLib_Unturned_Players");
                });

            modelBuilder.Entity("Pustalorc.PlayerInfoLib.Unturned.API.Classes.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Instance")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Pustalorc_PlayerInfoLib_Unturned_Servers");
                });

            modelBuilder.Entity("Pustalorc.PlayerInfoLib.Unturned.API.Classes.PlayerData", b =>
                {
                    b.HasOne("Pustalorc.PlayerInfoLib.Unturned.API.Classes.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
