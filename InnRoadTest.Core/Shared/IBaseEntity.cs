using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadTest.Core.Shared
{
    //Audit fields
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

    }
}
