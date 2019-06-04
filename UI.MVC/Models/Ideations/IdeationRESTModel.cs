using System;
using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models.Ideations
{
    public class IdeationRESTModel
    {
        public int IdeationId { get; set; }
        public Boolean AdminOnly { get; set; }
        public ICollection<IdeationQuestion> Questions { get; set; }
        public ICollection<Idea> Ideas { get; set; }
    }
}