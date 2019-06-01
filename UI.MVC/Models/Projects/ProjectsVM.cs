using System;
using System.Collections.Generic;
using D.UI.MVC.Models.Fields;
using Domain;

namespace D.UI.MVC.Models.Projects
{
    public class ProjectsVM
    {
        public ICollection<ProjectVM> Projects { get; set; }
        public ICollection<ProjectVM> OngoingProjects { get; set; }
    }
}