using System;
using System.Collections.Generic;

namespace SQLSVR_WEBAPI.Models
{
    public partial class PoolPoints
    {
        public int Ppid { get; set; }
        public string TeamId { get; set; }
        public short GameId { get; set; }
        public short Points { get; set; }
    }
}
