using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace UI.MVC.Models
{
    public class ProjectDetailModel
    {
        public Project Project { get; set; }
        public ICollection<IdeationQuestion> IdeationQuestions { get; set; }
        public Dictionary<int, int> LikeAmounts { get; set; }
        public Dictionary<int, int> CommentAmounts { get; set; }
    }
}