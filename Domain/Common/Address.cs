using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Address
    {
        [Required]
        public int AddressId { get; set; }
        public String Street { get; set; }
        public int Number { get; set; }
        public Place Place { get; set; }
    }
}