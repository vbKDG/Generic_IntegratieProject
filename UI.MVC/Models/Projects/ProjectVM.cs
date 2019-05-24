using System;
using System.Collections.Generic;
using D.UI.MVC.Models.Fields;
using Domain;

namespace D.UI.MVC.Models.Projects
{
    public class ProjectVM
    {
        public int projectId { get; set; }
        public string name { get; set; }
        
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string Base64Image { get; set; }
        
        public ImageFieldVm imageFieldVM { get; set; }
        
        public MapFieldVm mapFieldVM { get; set; }
        
        public SettingVM SettingVm { get; set; }
        
        public List<PhaseVM> phases { get; set; }
        private List<PhaseVM> _phases = new List<PhaseVM>();
        
        public bool Closed { get; set; }
        public int ideaAmount { get; set; }
        public int AmountOfLikes { get; set; }
        public int AmountOfComments { get; set; }
        public int CombinedTotal { get; set; }
        public int Progress { get; set; }
    }

    public class PhaseVM
    {
        public int PhaseId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class SettingVM
    {
        public int SettingId { get; set; }
        public string BackGroundColor1 { get; set; }
        public string BackGroundColor2 { get; set; }
        public string FontFamily { get; set; }
    }
}