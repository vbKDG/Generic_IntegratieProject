using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.EF;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Domain
{
    public class Reaction 
    {
        [Required]
        public  int reactionId { get; set; }
        [Required]
        public Idea idea { get; set; }
        public ApplicationUser user { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public ICollection<ReactionLike> reactionLikes { get; set; }
        public ICollection<Report> reports { get; set; }
        public bool approved { get; set; }
        public bool disapproved { get; set; }
        public bool verified { get; set; }
    }
}