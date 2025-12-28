using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Business.DTOs;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Interfaces
{
    public interface ISpreadService
    {
        IEnumerable<SpreadDto> GetAllSpreads();
        SpreadDto GetSpreadWithPositions(int spreadId);
    }
}
