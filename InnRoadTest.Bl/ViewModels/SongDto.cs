using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Bl.ViewModels
{
    public class SongDto : IBaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public TimeSpan Duration { get; set; }
        public double Price { get; set; }
        public double Popularity { get; set; }
    }
}
