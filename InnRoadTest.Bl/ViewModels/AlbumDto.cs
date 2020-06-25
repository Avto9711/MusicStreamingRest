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
    }
}
