using System;
using System.Collections.Generic;
using D.UI.MVC.Models.Fields;
using Domain;

namespace D.UI.MVC.Models.Projects
{
    public class ProjectVM
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Base64Image { get; set; }
        
        public ImageFieldVm ImageFieldVM { get; set; }
        
        public MapFieldVm MapFieldVM { get; set; }
        
        public SettingVM SettingVm { get; set; }
        
        public List<PhaseVM> Phases { get; set; }
        
        public bool Closed { get; set; }
        public int IdeaAmount { get; set; }
        public int AmountOfLikes { get; set; }
        public int AmountOfComments { get; set; }
        public int CombinedTotal { get; set; }
        public int Progress { get; set; }
        public bool Ongoing { get; set; }
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