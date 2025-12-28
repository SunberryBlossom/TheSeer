using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class ReadingHistoryDto
    {
        public Guid ReadingId { get; set; }
        public DateTime PerformedAt { get; set; }
        public string SpreadName { get; set; }
        public string Summary { get; set; }
    }
}
