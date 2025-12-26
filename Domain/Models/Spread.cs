using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class Spread
    {
        public int Id { get; set; }
        public int SystemTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? ImageOverlay  { get; set; }

        public SystemType SystemType { get; set; }
        public ICollection<Reading> Readings { get; set; } = new List<Reading>();
        public ICollection<SpreadPosition> SpreadPositions { get; set; } = new List<SpreadPosition>();

    }
}
