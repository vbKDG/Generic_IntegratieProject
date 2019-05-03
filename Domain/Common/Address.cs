using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Address
    {
        [Required]
        public int id { get; set; }
        public String street { get; set; }
        public int number { get; set; }
        public Place place { get; set; }
    }
}