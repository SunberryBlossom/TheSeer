using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.DTOs
{
    public class DeckListItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public bool IsFavorite { get; set; }
        public string Description { get; set; }
        public int CardCount { get; set; }
        public List<CardDetailDto> Cards { get; internal set; }
    }
}
