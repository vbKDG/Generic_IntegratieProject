using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ProjectLike : Like
    {
        public Project Project { get; set; }
    }
}