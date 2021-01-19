using AutoMapper;
using Familiada.Data;
using Familiada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Game, GameVM>().ReverseMap();
            //CreateMap<User, UserVM>().ReverseMap();
            CreateMap<Question, QuestionVM>().ReverseMap();
            CreateMap<Answer, AnswerVM>().ReverseMap();
        }
    }
}
