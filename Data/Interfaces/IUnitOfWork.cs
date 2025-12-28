using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICardRepository Cards { get; }
        IDeckRepository Decks { get; }
        ISystemTypeRepository SystemTypes { get; }
        ISpreadRepository Spreads { get; }
        ISpreadPositionRepository SpreadPositions { get; }
        IMeaningRepository Meanings { get; }
        IDrawnCardRepository DrawnCards { get; }
        IReadingRepository Readings { get; }
        IUserRepository Users { get; }
        IFavoriteDeckRepository FavoriteDecks { get; }
        IJournalEntryRepository JournalEntries { get; }

        int Save();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
