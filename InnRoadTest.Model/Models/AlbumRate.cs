using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InnRoadTest.Model.Models
{
    public class AlbumRate : IBaseEntity, ICreatedByAudit, IUpdatedByAuditable
    {
        public int Id { get ; set ; }
        public bool Deleted { get ; set ; }
        //here we can also use fluent validation. 
        [Range(0,5)]
        public double PointsGiven { get; set; }
        public string RateMesssage { get; set; }

        //TODO: Maybe an user can do the review?
        [NotMapped]
        public int UserId { get; set; }

        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        // user who created the rate
        public int? CreatedBy { get ; set ; }
        public int? UpdatedBy { get ; set ; }
        public DateTime? CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        public Album Album { get; set; }

    }
}
