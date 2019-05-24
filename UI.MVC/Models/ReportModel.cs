using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class ReportModel
    {
        public int SelectedProject { get; set; }
        public Idea Idea { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Ideation> Ideations { get; set; }
        public ICollection<Idea> Ideas { get; set; }
        public ICollection<Reaction> Reactions { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<TextField> TextFields { get; set; }
    }
}