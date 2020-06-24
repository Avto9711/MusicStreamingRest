using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Core.Shared
{
    public interface ICreatedByAudit
    {
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
