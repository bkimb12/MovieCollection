﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieCollection.Models;

namespace MovieCollection.Migrations
{
    [DbContext(typeof(MovieDatabaseContext))]
    [Migration("20220127060034_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieCollection.Models.AddMovie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Sports",
                            Director = "David Anspaugh",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Hoosiers",
                            Year = 1986
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Family",
                            Director = "Byron Howard, Jared Bush",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Encanto",
                            Year = 2021
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Action/Adventure",
                            Director = "Roland Emmerich",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Midway",
                            Year = 2019
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
