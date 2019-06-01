using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Ideation
    {
        [Required]     
        public int IdeationId { get; set; }     
        public Project Project { get; set; }
        public bool AdminOnly { get; set; }
        public bool Closed { get; set; }
        public ICollection<IdeationQuestion> Questions { get; set; }
        public ICollection<Idea> Ideas { get; set; }
        
        public FieldRange TextFieldRange { get; set; }
        
        public FieldRange ImageFieldRange { get; set; }
        
        public FieldRange VideoRange { get; set; }
        
        public FieldRange MapFieldRange { get; set; }
        
        public FieldRange QuestionFieldRange { get; set; }

        
        public ICollection<IotSetup> IotSetups { get; set; }
    }

}