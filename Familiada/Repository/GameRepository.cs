using Familiada.Contracts;
using Familiada.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Repository
{
    public class GameRepository : IGameRepository
    {
        
        private readonly ApplicationDbContext _db;

        public GameRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Game entity)
        {
            _db.Games.Add(entity);
            return Save();
        }

        public bool Delete(Game entity)
        {
            _db.Games.Remove(entity);
            return Save();
        }

        public ICollection<Game> FindAll()
        {
            var games = _db.Games.ToList();
            return games;
        }

        public Game FindById(int id)
        {
            var game = _db.Games.Find(id);
            return game;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Game entity)
        {
            _db.Games.Update(entity);
            return Save();
        }

    }
}
