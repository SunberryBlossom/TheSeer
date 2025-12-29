using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Business.DTOs
{
    public class DrawnCardDto
    {
        public string Card { get; set; }
        public int SpreadPositionId { get; set; }
        public string SpreadPosition { get; set; }
        public string SpreadPositionDescription { get; set; }
        public int DrawOrder { get; set; }
        public bool IsReversed { get; set; }
        public ICollection<Meaning> MeaningText { get; set; }
    }
}