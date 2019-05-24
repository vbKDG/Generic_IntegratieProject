using System;

namespace Domain
{
    public class Option
    {
        public int OptionId { get; set; }
        public String TheOption { get; set; }
        public Question Question { get; set; }
    }
}