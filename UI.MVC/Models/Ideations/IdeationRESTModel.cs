using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models.Ideations
{
    public class IdeationRESTModel
    {
        public int IdeationId { get; set; }

        public string Question { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfIdeas { get; set; }
    }
}