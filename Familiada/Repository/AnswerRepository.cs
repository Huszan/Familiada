using Familiada.Contracts;
using Familiada.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Repository
{
    public class AnswerRepository : IAnswerRepository
    {

        private readonly ApplicationDbContext _db;

        public AnswerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Answer entity)
        {
            _db.Answers.Add(entity);
            return Save();
        }

        public bool Delete(Answer entity)
        {
            _db.Answers.Remove(entity);
            return Save();
        }

        public ICollection<Answer> FindAll()
        {
            var answers = _db.Answers.ToList();
            return answers;
        }

        public Answer FindById(int id)
        {
            var answer = _db.Answers.Find(id);
            return answer;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Answer entity)
        {
            _db.Answers.Update(entity);
            return Save();
        }

    }
}
