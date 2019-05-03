using System;

namespace UI.MVC.Models
{
    public class QuestionUserModel
    {
        public int userId { get; set; }
        public int questionId { get; set; }
        public String Answer { get; set; }
    }
}