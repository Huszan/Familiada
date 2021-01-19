using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Data
{
    public class Answer
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string AnswerText { get; set; }
        [Required]
        public int Points { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        public int QuestionId { get; set; }

    }
}
