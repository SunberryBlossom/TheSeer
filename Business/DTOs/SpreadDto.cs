using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class SpreadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PositionCount { get; set; }
        public string SystemType { get; set; }
    }
}
