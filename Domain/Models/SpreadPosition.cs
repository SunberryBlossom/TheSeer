using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class SpreadPosition
    {
        public int Id { get; set; }
        public int SpreadId { get; set; }
        public int SequenceNumber { get; set; }
        public string? Label { get; set; }
        public string Description { get; set; } = null!;
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int RotationDegrees { get; set; }

        public Spread Spread { get; set; } = null!;
        public ICollection<DrawnCard> DrawnCards { get; set; } = new List<DrawnCard>();
    }
}
