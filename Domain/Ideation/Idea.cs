using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.EF;

namespace Domain
{
    public class Idea 
    {
    //
        [Required]     
        public int IdeaId { get; set; }
        public ApplicationUser User { get; set; } 
        public Ideation Ideation { get; set; }
        public ICollection<Reaction> Reactions { get; set; }
        public ICollection<IdeaLike> IdeaLikes { get; set; }
        public ICollection<Field> Fields { get; set; }
       // public ICollection<Question> questions { get; set; }
        public ICollection<Report> Reports { get; set; }
        public bool Approved { get; set; }
        public bool Disapproved { get; set; }
        public bool Verified { get; set; }
        public string IdeaTitle { get; set; }
    }
}