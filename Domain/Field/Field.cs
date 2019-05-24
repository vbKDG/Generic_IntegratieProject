using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Field
    {
        [Required] public int FieldId { get; set; }
        public Idea Idea { get; set; }
        public Boolean Required { get; set; }
    }

}