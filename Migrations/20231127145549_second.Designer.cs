﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperheroDB.Databas;

#nullable disable

namespace SuperheroDB.Migrations
{
    [DbContext(typeof(myDbContext))]
    [Migration("20231127145549_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SuperheroDB.Modeller.Superhero", b =>
                {
                    b.Property<int>("SuperheroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SuperheroId"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecretIdentity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SuperheroId");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            SuperheroId = 1,
                            ImageUrl = "Images/wonderwoman.jpg",
                            Name = "Wonder Woman",
                            SecretIdentity = "Diana Prince"
                        },
                        new
                        {
                            SuperheroId = 2,
                            ImageUrl = "Images/superman.jpg",
                            Name = "Superman",
                            SecretIdentity = "Clark Kent"
                        });
                });

            modelBuilder.Entity("SuperheroDB.Modeller.SuperheroSuperpowers", b =>
                {
                    b.Property<int>("SuperheroId")
                        .HasColumnType("int");

                    b.Property<int>("SuperpowerId")
                        .HasColumnType("int");

                    b.HasKey("SuperheroId", "SuperpowerId");

                    b.HasIndex("SuperpowerId");

                    b.ToTable("superPowers");

                    b.HasData(
                        new
                        {
                            SuperheroId = 1,
                            SuperpowerId = 1
                        },
                        new
                        {
                            SuperheroId = 1,
                            SuperpowerId = 2
                        },
                        new
                        {
                            SuperheroId = 2,
                            SuperpowerId = 1
                        });
                });

            modelBuilder.Entity("SuperheroDB.Modeller.Superpower", b =>
                {
                    b.Property<int>("SuperpowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SuperpowerId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SuperpowerId");

                    b.ToTable("Powers");

                    b.HasData(
                        new
                        {
                            SuperpowerId = 1,
                            Name = "Super Strength"
                        },
                        new
                        {
                            SuperpowerId = 2,
                            Name = "Flight"
                        },
                        new
                        {
                            SuperpowerId = 3,
                            Name = "Telekinesis"
                        });
                });

            modelBuilder.Entity("SuperheroDB.Modeller.SuperheroSuperpowers", b =>
                {
                    b.HasOne("SuperheroDB.Modeller.Superhero", "Superhero")
                        .WithMany("SuperheroSuperpowers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SuperheroDB.Modeller.Superpower", "Superpower")
                        .WithMany("SuperheroSuperpowers")
                        .HasForeignKey("SuperpowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");

                    b.Navigation("Superpower");
                });

            modelBuilder.Entity("SuperheroDB.Modeller.Superhero", b =>
                {
                    b.Navigation("SuperheroSuperpowers");
                });

            modelBuilder.Entity("SuperheroDB.Modeller.Superpower", b =>
                {
                    b.Navigation("SuperheroSuperpowers");
                });
#pragma warning restore 612, 618
        }
    }
}
