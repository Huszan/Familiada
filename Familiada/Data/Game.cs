using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Data
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public int Tries { get; set; }
        public int Points { get; set; }
        public bool Finished { get; set; }
    }
}
