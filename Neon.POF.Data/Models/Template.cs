using System;
using System.Collections.Generic;

namespace Neon.POF.Data.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string Title { get; set; }        
        public DateTime ReleasedOn { get; set; }
        public bool Active { get; set; }
        public ICollection<TemplateQuestion> TemplateQuestions { get; set; }
    }
}