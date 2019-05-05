using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Like
    {
        [Required]
        public int likeId { get; set; }
        public DateTime likeTime { get; set; }
        public string userId { get; set; }


    }
}