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
        public int ideaId { get; set; }
        
        public string IdeaTitle { get; set; }
        public ApplicationUser user { get; set; } 
        public Ideation ideation { get; set; }
        public ICollection<Reaction> reactions { get; set; }
        public ICollection<IdeaLike> ideaLikes { get; set; }
        public ICollection<Field> fields { get; set; }
       // public ICollection<Question> questions { get; set; }
        public ICollection<Report> reports { get; set; }
        public bool approved { get; set; }
        public bool disapproved { get; set; }
        public bool verified { get; set; }
    }
}