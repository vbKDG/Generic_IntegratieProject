using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class IotSetup
    {
        [Key]
        [Required]
        public int IotSetupId { get; set; }
        public Address Address { get; set; }
        
       
    }
}