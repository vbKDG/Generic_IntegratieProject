using System;
using System.Collections.Generic;

namespace Domain
{
    public class IotVote : Like
    {
        //public QuestionUser questionUser { get; set; }
        public Question question { get; set; }
       // public IotSetup iotSetup { get; set; }
        public Boolean confirmed { get; set; }
        public String email { get; set; }
    }
}