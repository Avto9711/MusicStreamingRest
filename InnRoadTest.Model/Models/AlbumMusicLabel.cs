using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InnRoadTest.Model.Models
{
    public class AlbumMusicLabel: IBaseEntity
    {
        public int Id { get; set; }
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        [ForeignKey("MusicLabel")]
        public int MusicLabelId { get; set; }
        public bool Deleted { get ; set ; }

        public virtual Album Album{ get; set; }
        public virtual MusicLabel MusicLabel { get; set; }
    }
}
