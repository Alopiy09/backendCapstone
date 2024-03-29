﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backEndCapstone.Data;

namespace backEndCapstone.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190614153553_ThirdMigration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("backEndCapstone.Models.Background", b =>
                {
                    b.Property<int>("BackgroundId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId");

                    b.Property<string>("backgroundAbilities")
                        .IsRequired();

                    b.Property<string>("description")
                        .IsRequired();

                    b.HasKey("BackgroundId");

                    b.ToTable("Background");
                });

            modelBuilder.Entity("backEndCapstone.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alignment");

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("BackgroundId");

                    b.Property<int>("BackgroundId1");

                    b.Property<int>("CharacterClassId");

                    b.Property<int>("Charisma");

                    b.Property<int>("Constitution");

                    b.Property<int>("Dexterity");

                    b.Property<int>("EquipmentId");

                    b.Property<int>("FeatId");

                    b.Property<int>("Intelligence");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("RaceId");

                    b.Property<int>("RaceId1");

                    b.Property<int>("Strength");

                    b.Property<int>("UserId");

                    b.Property<int>("Wisdom");

                    b.HasKey("CharacterId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("BackgroundId1");

                    b.HasIndex("RaceId1");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("backEndCapstone.Models.CharacterClass", b =>
                {
                    b.Property<int>("CharacterClassId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacterId");

                    b.Property<string>("ClassDescription")
                        .IsRequired();

                    b.Property<string>("ClassFeatures")
                        .IsRequired();

                    b.Property<string>("ClassName")
                        .IsRequired();

                    b.Property<int>("Experience");

                    b.Property<int>("SubClassId");

                    b.HasKey("CharacterClassId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("SubClassId");

                    b.ToTable("CharacterClass");
                });

            modelBuilder.Entity("backEndCapstone.Models.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Atunded");

                    b.Property<int?>("CharacterId");

                    b.Property<string>("EquipmentDescription")
                        .IsRequired();

                    b.Property<string>("EquipmentName")
                        .IsRequired();

                    b.HasKey("EquipmentId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("backEndCapstone.Models.Feat", b =>
                {
                    b.Property<int>("FeatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacterId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("featAbility");

                    b.HasKey("FeatId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Feat");
                });

            modelBuilder.Entity("backEndCapstone.Models.Race", b =>
                {
                    b.Property<int>("RaceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId");

                    b.Property<string>("RaceType")
                        .IsRequired();

                    b.Property<string>("RacialAbilities")
                        .IsRequired();

                    b.Property<int>("Speed");

                    b.HasKey("RaceId");

                    b.ToTable("Race");
                });

            modelBuilder.Entity("backEndCapstone.Models.Skills", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacterId");

                    b.Property<int>("SkillModifier");

                    b.Property<string>("SkillName")
                        .IsRequired();

                    b.Property<bool>("isProficient");

                    b.HasKey("SkillId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("backEndCapstone.Models.SubClass", b =>
                {
                    b.Property<int>("SubClassId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubClassClassId");

                    b.Property<string>("SubClassDescription")
                        .IsRequired();

                    b.Property<string>("SubClassFeatures")
                        .IsRequired();

                    b.Property<string>("SubClassName")
                        .IsRequired();

                    b.HasKey("SubClassId");

                    b.ToTable("SubClass");
                });

            modelBuilder.Entity("backEndCapstone.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("CharacterId");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("backEndCapstone.Models.Character", b =>
                {
                    b.HasOne("backEndCapstone.Models.ApplicationUser")
                        .WithMany("Characters")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("backEndCapstone.Models.Background", "background")
                        .WithMany()
                        .HasForeignKey("BackgroundId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("backEndCapstone.Models.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("backEndCapstone.Models.CharacterClass", b =>
                {
                    b.HasOne("backEndCapstone.Models.Character")
                        .WithMany("characterClasses")
                        .HasForeignKey("CharacterId");

                    b.HasOne("backEndCapstone.Models.SubClass", "SubClass")
                        .WithMany()
                        .HasForeignKey("SubClassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("backEndCapstone.Models.Equipment", b =>
                {
                    b.HasOne("backEndCapstone.Models.Character")
                        .WithMany("equipment")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("backEndCapstone.Models.Feat", b =>
                {
                    b.HasOne("backEndCapstone.Models.Character")
                        .WithMany("feats")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("backEndCapstone.Models.Skills", b =>
                {
                    b.HasOne("backEndCapstone.Models.Character")
                        .WithMany("Skill")
                        .HasForeignKey("CharacterId");
                });
#pragma warning restore 612, 618
        }
    }
}
