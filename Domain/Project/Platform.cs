using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Platform
    {
        [Required]
        public int id { get; set; }
        public String name { get; set; }
        public IEnumerable<Project> projects { get; set; }
    }
}