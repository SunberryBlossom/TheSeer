using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class MeaningDto
    {
        public string Category { get; set; }
        public string Content { get; set; }
        public string KeyWords { get; set; }
        public bool IsReversed { get; set; }
    }
}
