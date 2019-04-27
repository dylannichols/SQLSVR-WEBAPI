using System;
using System.Collections.Generic;

namespace SQLSVR_WEBAPI.Models
{
    public partial class Staff
    {
        public short StaffId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string TeamId { get; set; }
    }
}
