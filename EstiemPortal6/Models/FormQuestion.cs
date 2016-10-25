using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Models
{
    public class FormQuestion
    {
        public int QuestionId { get; set; }
        public int FormId { get; set; }
        public string Question { get; set; }

    } 

    public class FormQuestionAnswer
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }

    public class Form
    {
        public int FormId { get; set; }
        public string Name { get; set; }
        public IEnumerable<FormQuestion> Questions { get; set; }
        public DateTime Created { get; set; }
    }
}