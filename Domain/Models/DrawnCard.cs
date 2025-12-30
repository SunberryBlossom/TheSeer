using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class DrawnCard
    {
        public Guid ReadingId { get; set; }
        public int SpreadPositionId { get; set; }
        public int CardId { get; set; }
        public bool IsReversed { get; set; }
        public int DrawOrder { get; set; }
        public string? UserNote { get; set; } // not yet implemented in logic! Future model property if one wants to add note to a specific card

        public Reading Reading { get; set; } = null!;
        public SpreadPosition SpreadPosition { get; set; } = null!;
        public Card Card { get; set; } = null!;
    }
}
