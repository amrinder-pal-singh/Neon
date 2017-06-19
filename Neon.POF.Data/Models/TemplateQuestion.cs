namespace Neon.POF.Data.Models
{
    public class TemplateQuestion
    {
        public int TemplateId { get; set; }
        public Template Template { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int SortingOrder { get; set; }
    }
}