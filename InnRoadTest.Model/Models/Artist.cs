using InnRoadTest.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Model.Models
{
    public class Artist : IBaseEntity, ICreatedByAudit, IUpdatedByAuditable
    {

        public Artist()
        {
            Albums = new List<Album>();
        }
        public int Id { get ; set ; }
        public string Name { get; set; }

        public bool Deleted { get ; set ; }
        public int? CreatedBy { get ; set ; }
        public int? UpdatedBy { get ; set ; }
        public DateTime? CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}
