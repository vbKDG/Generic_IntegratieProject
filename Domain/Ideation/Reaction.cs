using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Domain
{
    public class Reaction 
    {
        [Required]
        public  int reactionId { get; set; }
        [Required]
        public Idea idea { get; set; }
        public string UserId { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public ICollection<ReactionLike> reactionLikes { get; set; }
        
    }
}