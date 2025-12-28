using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class JournalEntryDto
    {
        public Guid Id { get; set; }
        public Guid ReadingId { get; set; }
        public DateTime ReadingDate { get; set; }
        public string SpreadName { get; set; }
        public string TextContent { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
