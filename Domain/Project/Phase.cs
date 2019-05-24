using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Phase
    {
        [Required]     
        public int PhaseId { get; set; }
        public Project Project { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}