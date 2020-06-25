using InnRoadTest.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnRoadTest.Model.Seed
{
    public static class SeedData
    {
        private readonly static DateTime NowDate = DateTime.Now;
        public static Genre GenreSeed
        {
            get
            {
                return new Genre
                {
                    Id = 1,
                    Name = "Pop",
                    CreatedDate = NowDate
                };
            }
        }

        public static Artist ArtistSeed
        {
            get
            {
                return new Artist
                {
                    Id =1,
                    Name ="Basckstreet boys",
                    CreatedDate = NowDate

                };
            }
        }

        public static ICollection<MusicLabel> MusicLabelSeed
        {
            get
            {
                return new List<MusicLabel>
                {
                    new MusicLabel
                    {
                        Id=1,
                        Name = "K-Bahn, LLC",
                        CreatedDate = NowDate,
                    },
                    new MusicLabel
                    {
                        Id=2,
                        Name = "RCA Records",
                        CreatedDate = NowDate
                    }
                };
            }
        }

        public static ICollection<AlbumMusicLabel> AlbumMusicLabelSeed
        {
            get
            {
                return new List<AlbumMusicLabel> {
                        new AlbumMusicLabel
                        {
                            Id = 1,
                            MusicLabelId = 1,
                            AlbumId = 1


                        },
                        new AlbumMusicLabel
                        {
                            Id = 2,
                            MusicLabelId = 2,
                            AlbumId = 1

                        }
                    };
            }
        }

        public static ICollection<AlbumRate> AlbumRatesSeed
        {
            get
            {
                return new List<AlbumRate>
                {
                    new AlbumRate
                    {
                        Id = 1,
                        PointsGiven = 4,
                        RateMesssage ="Great Album",
                        CreatedDate = NowDate,
                        AlbumId = 1
                    },
                    new AlbumRate
                    {
                        Id = 2,
                        PointsGiven = 5,
                        RateMesssage ="Excellent Album",
                        CreatedDate = NowDate,
                        AlbumId = 1

                    }
                };
            }
        }
        public static ICollection<Song> SongsSeed
        {
            get
            {
                return new List<Song>
                {
                    new Song
                    {
                        Id = 1,
                        Name ="Don't Go Breaking My Heart",
                        Price = 1.29,
                        Popularity = 5,
                        CreatedDate = NowDate,
                        AlbumId = 1
                    },
                    new Song
                    {
                        Id = 2,
                        Name ="Nobody Else",
                        Price = 1.29,
                        Popularity = 5,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 3,
                        Name ="Breathe",
                        Popularity = 5,
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },

                    new Song
                    {
                        Id = 4,
                        Name ="New Love",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 5,
                        Name ="Passionate",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 6,
                        Name ="Is Just Me",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 7,
                        Name ="Chances",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 8,
                        Name ="No Place",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 9,
                        Name ="Chateau",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 10,
                        Name ="The Way It Was",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 11,
                        Name ="Just Like You Like It",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                    new Song
                    {
                        Id = 12,
                        Name ="Ok",
                        Price = 1.29,
                        CreatedDate = NowDate,
                        AlbumId = 1

                    },
                };
            }
        }
        public static Album AlbumSeed
        {
            get
            {
                return new Album
                {
                    Id = 1,
                    Name = "DNA",
                    Review = "There’s one question the Backstreet Boys can’t seem to escape: Do they still consider themselves a boy band? " +
                    "The five-piece, most of whom are now over 40 and married with children, have come to embrace the term. " +
                    "“At this point, ‘boys' has come to mean more, like, ‘friends,’ Kevin Richardson told Apple Music’s Arjan " +
                    "Timmermans. “It keeps us young.” There might be some truth to that.On their ninth album DNA , the group dabbles in the " +
                    "sounds that are driving mainstream music in 2019: mid-tempo EDM (“Don’t Go Breaking My Heart”), " +
                    "’80s-inspired synth-pop (“Is It Just Me”), and heart-on-sleeve country (“You’re my daybreak/You’re my California sun/You’re my Memphis, New York, " +
                    "New Orleans all rolled into one,” they croon on “No Place”). " +
                    "Even when they’re experimenting, though, they always feel familiar—they’ve still got those irresistible " +
                    "five-part harmonies, R&B leanings, and swoonworthy come-ons that made fans fall in love with them 25 years ago. " +
                    "The slick and swaggering “New Love”" +
                    " sounds like classic BSB. “There are moments when all five of us are like, " +
                    "‘Oh, dude, absolutely,’” Brian Littrell said of the moment they first heard the song. “That’s what you’re striving for.”",
                    AlbumCover = "https://is2-ssl.mzstatic.com/image/thumb/Music128/v4/fb/32/2e/fb322ed2-a171-4909-86f0-7bf487a7b811/886447390108.jpg/1000x1000bb.jpg",
                    GenreId = 1,
                    ReleaseDate = new DateTime(2019, 1, 25),
                    Price = 11.99,
                    ArtistId= 1,
                    CreatedDate = NowDate
                };
            }
        }
    }
}
