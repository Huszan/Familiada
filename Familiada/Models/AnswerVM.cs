using Familiada.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Models
{
    public class AnswerVM
    {
        public int Id { get; set; }
        [Display(Name="Answer Text")]
        public string AnswerText { get; set; }
        public string Points { get; set; }
        public QuestionVM Question { get; set; }
        public int QuestionId { get; set; }
        //public IEnumerable<SelectListItem> Questions { get; set; } //Dropdown list of questions
    }
}
