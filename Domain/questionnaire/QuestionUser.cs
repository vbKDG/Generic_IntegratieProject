using System;
using DAL.EF;

namespace Domain
{
    public class QuestionUser
    {
        public int id { get; set; }
        public Question Question { get; set; }
        public String Answer { get; set; }
        public ApplicationUser User { get; set;  }
        public bool Confirmed { get; set; }
    }
}