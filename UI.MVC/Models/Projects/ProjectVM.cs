using System;
using System.Collections.Generic;
using D.UI.MVC.Models.Fields;
using Domain;

namespace D.UI.MVC.Models.Projects
{
    public class ProjectVM
    {
        public string name { get; set; }
        
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        
        public ImageFieldVm imageFieldVM { get; set; }
        
        public MapFieldVm mapFieldVM { get; set; }
        
        public SettingVM SettingVm { get; set; }
        
        public List<PhaseVM> phases
        {
            get { return _phases; }
        }
        private List<PhaseVM> _phases = new List<PhaseVM>();
    }

    public class PhaseVM
    {
        public String name { get; set; }
        public String description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }

    public class SettingVM
    {
        public string BackGroundColor1 { get; set; }
        public string BackGroundColor2 { get; set; }
        public string FontFamily { get; set; }
    }
}