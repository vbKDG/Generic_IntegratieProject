using System;

namespace Domain
{
    public class QuestionUser
    {
        public int id { get; set; }
        public Question Question { get; set; }
        public User User { get; set; }
        public String Answer { get; set; }
    }
}