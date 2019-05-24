using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Project 
    {
        [Required]     
        public int ProjectId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Closed { get; set; }
        public ImageField ImageField { get; set; }
        public MapField MapField { get; set; }
        public Place Place { get; set; }
        public ICollection<Ideation> Ideations { get; set; }
        public ICollection<Questionnaire> Questionnaires { get; set; }
        public ICollection<Phase> Phases { get; set; }
        public ICollection<ProjectLike> ProjectLikes { get; set; }
        public Setting Setting { get; set; }
    }
}    