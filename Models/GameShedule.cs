using System;
using System.Collections.Generic;

namespace SQLSVR_WEBAPI.Models
{
    public partial class GameShedule
    {
        public short GameId { get; set; }
        public short FieldNumber { get; set; }
        public string Time { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public short? TeamAScore { get; set; }
        public short? TeamBScore { get; set; }
    }
}
