using System.Drawing;

namespace UI.MVC.Models.Projects
{
    public class ProjectRESTModelBasic
    {
        public int projectId { get; set; }
        public string name { get; set; }
        public int numberOfLikes { get; set; }
        public int numberOfIdeations { get; set; }
        //public int numberOfReports { get; set; }
    }
}