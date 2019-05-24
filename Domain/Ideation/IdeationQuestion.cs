using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class IdeationQuestion
    {
        [Required]     
        [Key]
        public int IdeationQuestonId { get; set; }
        
        public Ideation Ideation { get; set; }
        public string Question { get; set; }
        public string Description { get; set; }
        public string BackgroundInfo { get; set; }
    }
}