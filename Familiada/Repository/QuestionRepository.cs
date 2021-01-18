using Familiada.Contracts;
using Familiada.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Repository
{
    public class QuestionRepository : IQuestionRepository
    {

        private readonly ApplicationDbContext _db;

        public QuestionRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Question entity)
        {
            _db.Questions.Add(entity);
            return Save();
        }

        public bool Delete(Question entity)
        {
            _db.Questions.Remove(entity);
            return Save();
        }

        public ICollection<Question> FindAll()
        {
            var questions = _db.Questions.ToList();
            return questions;
        }

        public Question FindById(int id)
        {
            var question = _db.Questions.Find(id);
            return question;
        }

        public ICollection<Question> GetAnswersByQuestionId(int id)
        {
            throw new NotImplementedException(); //TODO
        }

        public bool isExists(int id)
        {
            var exists = _db.Questions.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Question entity)
        {
            _db.Questions.Update(entity);
            return Save();
        }

    }
}
