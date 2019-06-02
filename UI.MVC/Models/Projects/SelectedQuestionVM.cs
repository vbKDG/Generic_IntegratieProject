using System;
using System.Collections.Generic;
using D.UI.MVC.Models.Fields;
using Domain;

namespace D.UI.MVC.Models.Projects
{
    public class SelectedQuestionVM
    {
        public Question Question { get; set; }
        public int QuestionAnswerCount { get; set; }
        public ICollection<OptionsVM> OptionsVms { get; set; }
    }

    public class OptionsVM
    {
        public Option Option { get; set; }
        public int OptionVoteCount { get; set; }
    }
}