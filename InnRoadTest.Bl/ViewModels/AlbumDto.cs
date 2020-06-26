using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Bl.ViewModels
{
    public class AlbumDto: IBaseDto
    {
        public int Id { get; set; }
        public string AlbumCover { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
        public double Price { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public double AlbumAvgRating { get; set; } = 0;
        public int AlbumAvgTotal { get; set; } = 0;

    }
}
