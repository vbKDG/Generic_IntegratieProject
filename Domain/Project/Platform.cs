using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Platform
    {
        [Required]
        public int PlatformId { get; set; }
        public String Name { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}