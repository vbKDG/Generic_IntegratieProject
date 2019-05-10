using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Field
    {
        [Required] public int fieldId { get; set; }
        public Idea idea { get; set; }
        public Boolean required { get; set; }
    }

}