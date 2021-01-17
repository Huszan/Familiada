using Familiada.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Contracts
{
    public interface IQuestionRepository : IRepositoryBase<Question>
    {
        ICollection<Question> GetAnswersByQuestionId(int id);
    }
}
