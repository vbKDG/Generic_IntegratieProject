using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class IdeationQuestion
    {
        [Required]     
        [Key]
        public int ideationQuestonId { get; set; }
        
        public Ideation ideation { get; set; }
        public string question { get; set; }
        public int like { get; set; }
        
        
    }
}