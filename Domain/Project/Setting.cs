using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.EF;

namespace Domain
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }
        [Required]
        public Project Project { get; set; }
        public string BackGroundColor1 { get; set; }
        public string BackGroundColor2 { get; set; }
        public string FontFamily { get; set; }
    }
}