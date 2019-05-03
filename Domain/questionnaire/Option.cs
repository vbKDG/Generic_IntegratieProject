using System;

namespace Domain
{
    public class Option
    {
        public int id { get; set; }
        public String option { get; set; }
        public Question question { get; set; }
    }
}