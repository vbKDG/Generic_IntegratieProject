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
        public  int ReactionId { get; set; }
        [Required]
        public Idea Idea { get; set; }
        public ApplicationUser User { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ReactionLike> ReactionLikes { get; set; }
        public ICollection<Report> Reports { get; set; }
        public bool Approved { get; set; }
        public bool Disapproved { get; set; }
        public bool Verified { get; set; }
    }
}