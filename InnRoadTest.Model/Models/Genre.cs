using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InnRoadTest.Model.Models
{
    public class Genre : IBaseEntity, ICreatedByAudit, IUpdatedByAuditable
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("ParentGenre")]
        public int? ParentGenreId { get; set; }
        public bool Deleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Genre ParentGenre { get; set; }
    }
}
