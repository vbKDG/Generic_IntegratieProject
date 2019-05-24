using System;
using System.ComponentModel.DataAnnotations;
using DAL.EF;

namespace Domain
{
    public class Like
    {
        [Required]
        public int LikeId { get; set; }
        public DateTime LikeTime { get; set; }
        public ApplicationUser User { get; set; }
    }
}