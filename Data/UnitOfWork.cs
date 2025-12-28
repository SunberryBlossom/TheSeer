using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Data.Repositories;

namespace TheSeer.Data
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly TheSeerDbContext _context;
        private IDbContextTransaction _transaction;

        public ICardRepository Cards { get; private set; }
        public IDeckRepository Decks { get; private set; }
        public ISystemTypeRepository SystemTypes { get; private set; }
        public ISpreadRepository Spreads { get; private set; }
        public ISpreadPositionRepository SpreadPositions { get; private set; }
        public IMeaningRepository Meanings { get; private set; }
        public IDrawnCardRepository DrawnCards { get; private set; }
        public IReadingRepository Readings { get; private set; }
        public IUserRepository Users { get; private set; }
        public IFavoriteDeckRepository FavoriteDecks { get; private set; }
        public IJournalEntryRepository JournalEntries { get; private set; }

        public UnitOfWork(TheSeerDbContext context)
        {
            _context = context;


            Cards = new CardRepository(_context);
            Decks = new DeckRepository(_context);
            SystemTypes = new SystemTypeRepository(_context);
            Spreads = new SpreadRepository(_context);
            SpreadPositions = new SpreadPositionRepository(_context);
            Meanings = new MeaningRepository(_context);
            DrawnCards = new DrawnCardRepository(_context);
            Readings = new ReadingRepository(_context);
            Users = new UserRepository(_context);
            FavoriteDecks = new FavoriteDeckRepository(_context);
            JournalEntries = new JournalEntryRepository(_context);
        }

        public int Save() => _context.SaveChanges();
        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
                _transaction?.Commit();
            }
            catch
            {
                Rollback();
                throw;
            }
            finally
            {
                _transaction?.Dispose();
                _transaction = null;
            }
        }

        public void Rollback()
        {
            _transaction?.Rollback();
            _transaction?.Dispose();
            _transaction = null;
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context.Dispose();
        }
    }

}
