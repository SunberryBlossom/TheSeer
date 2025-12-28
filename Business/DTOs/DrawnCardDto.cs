using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class DrawnCardDto
    {
        public string CardName { get; set; }
        public string PositionName { get; set; }
        public string PositionDescription { get; set; }
        public string MeaningText { get; set; }
        public bool IsReversed { get; set; }
    }
}
