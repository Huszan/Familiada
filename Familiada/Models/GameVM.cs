using Familiada.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Models
{
    public class GameVM
    {
        public int Id { get; set; }
        public QuestionVM Question { get; set; }
        public int QuestionId { get; set; }
        //public UserVM User { get; set; }
        //public string UserId { get; set; }
        public int Tries { get; set; }
        public int Points { get; set; }
        public bool Finished { get; set; }
    }
}
