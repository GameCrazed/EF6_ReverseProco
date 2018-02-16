

namespace Generator
{

    public class EaUpfrontquestion
    {
        public int UpFrontQuestionId { get; set; }
        public System.DateTime DateFrom { get; set; }
        public int QuestionOrder { get; set; }
        public string Division { get; set; }
        public System.DateTime DateExpired { get; set; }
        public string Question { get; set; }
        public byte Answer { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string LoanType { get; set; }
    }

}
