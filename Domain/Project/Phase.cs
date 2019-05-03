using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Phase
    {
        [Required]     
        public int phaseId { get; set; }
        
        
        public Project project { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}