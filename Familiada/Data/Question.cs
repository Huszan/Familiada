using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Data
{
    public class Question
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string QuestionText { get; set; }

    }
}
