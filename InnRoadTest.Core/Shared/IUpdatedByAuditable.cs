using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Core.Shared
{
    public interface IUpdatedByAuditable
    {
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
