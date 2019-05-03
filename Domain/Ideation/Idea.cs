using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Idea 
    {
    //
        [Required]     
        public int ideaId { get; set; }
        public User user { get; set; }
        
       
        public Ideation ideation { get; set; }
      
        
         
        public ICollection<Reaction> reactions { get; set; }
        public ICollection<IdeaLike> ideaLikes { get; set; }
        public ICollection<Field> fields { get; set; }
        
    }
}