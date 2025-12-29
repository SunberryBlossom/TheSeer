using System;
using System.Collections.Generic;
using System.Linq;
using TheSeer.Business.Interfaces;
using TheSeer.Business.DTOs;
using TheSeer.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TheSeer.Business.Services
{
    public class SpreadService : ISpreadService
    {
        private readonly IUnitOfWork _uow;

        public SpreadService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<SpreadDto> GetAllSpreads()
        {
            var spreads = _uow.Spreads.GetAll().Include(s => s.SystemType);

            return spreads.Select(s => new SpreadDto
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                PositionCount = s.SpreadPositions.Count,
                SystemType = s.SystemType.Name
            });
        }

        public SpreadDto GetSpreadWithPositions(int spreadId)
        {
            var spread = _uow.Spreads.GetSpreadWithPositions(spreadId);

            if (spread == null) return null;

            return new SpreadDto
            {
                Id = spread.Id,
                Name = spread.Name,
                Description = spread.Description,
                PositionCount = spread.SpreadPositions.Count
            };
        }
    }
}