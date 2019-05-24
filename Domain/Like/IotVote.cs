using System;
using System.Collections.Generic;

namespace Domain
{
    public class IotVote : Like
    {
        public Question Question { get; set; }
        public Boolean Confirmed { get; set; }
        public String Email { get; set; }
    }
}