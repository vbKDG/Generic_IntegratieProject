using System;
using System.Collections.Generic;
using System.Drawing;
using Domain;

namespace D.UI.MVC.Models
{
    public class ProjectRESTModel
    {
        public int projectId { get; set; }
        public string name { get; set; }
        public Bitmap projectImage { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int numberOfLikes { get; set; }
        public int numberOfIdeations { get; set; }
        public int percentageCompleted { get; set; }
    }
}