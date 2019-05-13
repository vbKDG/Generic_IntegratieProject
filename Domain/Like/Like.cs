using System;
using System.ComponentModel.DataAnnotations;
using DAL.EF;

namespace Domain
{
    public class Like
    {
        [Required]
        public int likeId { get; set; }
        public DateTime likeTime { get; set; }
        public ApplicationUser User { get; set; }


    }
}