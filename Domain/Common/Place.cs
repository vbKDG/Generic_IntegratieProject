using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Place
    {
        [Required]
        public int PlaceId { get; set; }
        public String Name { get; set; }
        public String PostalCode { get; set; }
    }
}