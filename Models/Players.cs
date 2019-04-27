using System;
using System.Collections.Generic;

namespace SQLSVR_WEBAPI.Models
{
    public partial class Players
    {
        public short PlayerId { get; set; }
        public string Name { get; set; }
        public string TeamId { get; set; }
    }
}
