﻿// <auto-generated />
using System;
using InnRoadTest.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InnRoadTest.Model.Migrations
{
    [DbContext(typeof(InnRoadTestDbContext))]
    [Migration("20200626144201_AddedSongsDuration")]
    partial class AddedSongsDuration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InnRoadTest.Model.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumCover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumCover = "https://is2-ssl.mzstatic.com/image/thumb/Music128/v4/fb/32/2e/fb322ed2-a171-4909-86f0-7bf487a7b811/886447390108.jpg/1000x1000bb.jpg",
                            ArtistId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            GenreId = 1,
                            Name = "DNA",
                            Price = 11.99,
                            ReleaseDate = new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "There’s one question the Backstreet Boys can’t seem to escape: Do they still consider themselves a boy band? The five-piece, most of whom are now over 40 and married with children, have come to embrace the term. “At this point, ‘boys' has come to mean more, like, ‘friends,’ Kevin Richardson told Apple Music’s Arjan Timmermans. “It keeps us young.” There might be some truth to that.On their ninth album DNA , the group dabbles in the sounds that are driving mainstream music in 2019: mid-tempo EDM (“Don’t Go Breaking My Heart”), ’80s-inspired synth-pop (“Is It Just Me”), and heart-on-sleeve country (“You’re my daybreak/You’re my California sun/You’re my Memphis, New York, New Orleans all rolled into one,” they croon on “No Place”). Even when they’re experimenting, though, they always feel familiar—they’ve still got those irresistible five-part harmonies, R&B leanings, and swoonworthy come-ons that made fans fall in love with them 25 years ago. The slick and swaggering “New Love” sounds like classic BSB. “There are moments when all five of us are like, ‘Oh, dude, absolutely,’” Brian Littrell said of the moment they first heard the song. “That’s what you’re striving for.”"
                        });
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.AlbumMusicLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("MusicLabelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("MusicLabelId");

                    b.ToTable("AlbumMusicLabels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Deleted = false,
                            MusicLabelId = 1
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            Deleted = false,
                            MusicLabelId = 2
                        });
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.AlbumRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<double>("PointsGiven")
                        .HasColumnType("float");

                    b.Property<string>("RateMesssage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("AlbumRates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            PointsGiven = 4.0,
                            RateMesssage = "Great Album"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            PointsGiven = 5.0,
                            RateMesssage = "Excellent Album"
                        });
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistCover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Name = "Basckstreet boys"
                        });
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentGenreId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentGenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Name = "Pop"
                        });
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.MusicLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MusicLabels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Name = "K-Bahn, LLC"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Name = "RCA Records"
                        });
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Popularity")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 36, 0),
                            Name = "Don't Go Breaking My Heart",
                            Popularity = 5.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 38, 0),
                            Name = "Nobody Else",
                            Popularity = 5.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 6, 0),
                            Name = "Breathe",
                            Popularity = 5.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 0, 0),
                            Name = "New Love",
                            Popularity = 0.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 43, 0),
                            Name = "Passionate",
                            Popularity = 0.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 6,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 37, 0),
                            Name = "Is Just Me",
                            Popularity = 0.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 7,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 2, 53, 0),
                            Name = "Chances",
                            Popularity = 0.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 8,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 2, 59, 0),
                            Name = "No Place",
                            Popularity = 0.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 9,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 8, 0),
                            Name = "Chateau",
                            Popularity = 0.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 10,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 26, 0),
                            Name = "The Way It Was",
                            Popularity = 0.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 11,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 42, 0),
                            Name = "Just Like You Like It",
                            Popularity = 0.0,
                            Price = 1.29
                        },
                        new
                        {
                            Id = 12,
                            AlbumId = 1,
                            CreatedDate = new DateTime(2020, 6, 26, 10, 42, 0, 889, DateTimeKind.Local).AddTicks(1720),
                            Deleted = false,
                            Duration = new TimeSpan(0, 0, 3, 31, 0),
                            Name = "Ok",
                            Popularity = 0.0,
                            Price = 1.29
                        });
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.Album", b =>
                {
                    b.HasOne("InnRoadTest.Model.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InnRoadTest.Model.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.AlbumMusicLabel", b =>
                {
                    b.HasOne("InnRoadTest.Model.Models.Album", "Album")
                        .WithMany("AlbumMusicLabels")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InnRoadTest.Model.Models.MusicLabel", "MusicLabel")
                        .WithMany()
                        .HasForeignKey("MusicLabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.AlbumRate", b =>
                {
                    b.HasOne("InnRoadTest.Model.Models.Album", "Album")
                        .WithMany("AlbumRates")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.Genre", b =>
                {
                    b.HasOne("InnRoadTest.Model.Models.Genre", "ParentGenre")
                        .WithMany()
                        .HasForeignKey("ParentGenreId");
                });

            modelBuilder.Entity("InnRoadTest.Model.Models.Song", b =>
                {
                    b.HasOne("InnRoadTest.Model.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
