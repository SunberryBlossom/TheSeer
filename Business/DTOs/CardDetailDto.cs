using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class CardDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Suit { get; set; }
        public List<MeaningDto> Meanings { get; set; } = new();
        public int Value { get; set; }
        public string Description { get; set; }
    }
}
