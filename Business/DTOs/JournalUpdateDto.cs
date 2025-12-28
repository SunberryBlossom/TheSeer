using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class JournalUpdateDto
    {
        public Guid Id { get; set; }
        public string NewTextContent { get; set; }
    }
}
