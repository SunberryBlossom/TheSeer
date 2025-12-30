using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class JournalEntry
    {
        public Guid Id { get; set; }
        public Guid ReadingId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateWritten { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Header { get; set; } = null!;
        public string Content { get; set; } = null!;

        public Reading Reading { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
