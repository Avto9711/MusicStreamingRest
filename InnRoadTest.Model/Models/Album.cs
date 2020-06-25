using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InnRoadTest.Model.Models
{
    public class Album : IBaseEntity, ICreatedByAudit, IUpdatedByAuditable
    {
        public Album()
        {
            AlbumRates = new List<AlbumRate>();
            AlbumMusicLabels = new List<AlbumMusicLabel>();
        }
        public int Id { get; set; }

        //cover image from an azure storage account or another cloud File Storage
        public string AlbumCover { get; set; }
        [StringLength(60)]
        public string Name { get; set; }
        [StringLength(int.MaxValue)]
        public string Review { get; set; }
        public double Price { get; set; }
        [ForeignKey("Artist")]
        public int ArtistId { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        [NotMapped]
        public double AlbumAvgRating { get {
                return  this.AlbumRates.Count > 0 ? (this.AlbumRates.Sum(y=>y.PointsGiven) / this.AlbumRates.Count) : 0 ;
            }
        }
        public bool Deleted { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<AlbumRate> AlbumRates {get ;set; }
        public virtual ICollection <AlbumMusicLabel> AlbumMusicLabels { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

    }
}
