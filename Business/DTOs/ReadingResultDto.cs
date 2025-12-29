using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class ReadingResultDto
    {
        public Guid ReadingId { get; set; }
        public DateTime PerformedAt { get; set; }
        public string SpreadName { get; set; }
        public string Question { get; set; }
        public List<DrawnCardDto> DrawnCards { get; set; } = new();
    }
}
