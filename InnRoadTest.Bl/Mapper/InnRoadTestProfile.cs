using AutoMapper;
using InnRoadTest.Bl.ViewModels;
using InnRoadTest.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Bl.Mapper
{
    public class InnRoadTestProfile: Profile
    {
        public InnRoadTestProfile()
        {
            CreateMap<Album, AlbumDto>()
                .ForMember(y=>y.ArtistName, cfg=> cfg.MapFrom(y=>y.Artist.Name))
                .ForMember(y => y.GenreName, cfg => cfg.MapFrom(y => y.Genre.Name))
            .ReverseMap();

            CreateMap<Song, SongDto>()
                .ForMember(y=>y.AlbumName, cfg=> cfg.MapFrom(y=>y.Album.Name))
                .ReverseMap();


        }
    }
}
