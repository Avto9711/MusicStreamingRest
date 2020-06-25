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
            CreateMap<Album, AlbumDto>().ReverseMap();
        }
    }
}
