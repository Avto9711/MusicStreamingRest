using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InnRoadTest.Model.Models
{
    public class Song : IBaseEntity, ICreatedByAudit, IUpdatedByAuditable
    {
        public int Id { get ; set ; }
        public bool Deleted { get ; set ; }
        public string Name { get; set; }
        [ForeignKey("AlbumId")]
        public int AlbumId { get; set; }
        public TimeSpan Duration { get; set; }
        public double Price { get; set; }

        [Range(0,10)]
        public double Popularity { get; set; }
        public int? UpdatedBy { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        public int? CreatedBy { get ; set ; }
        public DateTime? CreatedDate { get ; set ; }
        public virtual Album Album { get; set; }
        public virtual Artist Artist { get; set; }

    }
}
