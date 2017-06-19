using System.Collections.Generic;

namespace Neon.POF.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public ICollection<TemplateQuestion> TemplateQuestions { get; set; }
    }
}