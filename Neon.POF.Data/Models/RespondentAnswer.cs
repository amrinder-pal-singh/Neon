namespace Neon.POF.Data.Models
{
    public class RespondentAnswer
    {
        public int Id { get; set; }
        public int RespondentID { get; set; }
        public Respondent Respondent { get; set; }
        public int TemplateId { get; set; }
        public Template Template { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string  Answer { get; set; }
    }
}