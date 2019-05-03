using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class IotSetup
    {
        [Key]
        [Required]
        public int iotId { get; set; }
        public Address address { get; set; }
        
       
    }
}