using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Like
    {
        [Required]
        public int likeId { get; set; }
        public DateTime likeTime { get; set; }
        public User user { get; set; }


    }
}