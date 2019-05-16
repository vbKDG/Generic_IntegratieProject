using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class ReportModel
    {
        public int selectedProject { get; set; }
        public Idea idea { get; set; }
        public ICollection<Project> projects { get; set; }
        public ICollection<Ideation> ideations { get; set; }
        public ICollection<Idea> ideas { get; set; }
        public ICollection<Reaction> reactions { get; set; }
        public ICollection<Report> reports { get; set; }
        public ICollection<TextField> TextFields { get; set; }
    }
}