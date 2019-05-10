using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain;

namespace UI.MVC.Models.Ideations
{
    public class IdeationVM
    {
        public int ProjectId { get; set; }
        public String ProjectName { get; set; }
        
        public Boolean AdminOnly { get; set; }
        
        public String link { get; set; }
        
        public FieldRange TextField { get; set; }
        public FieldRange ImageField { get; set; }
        public FieldRange VideoField { get; set; }
        public FieldRange MapField { get; set; }
        public FieldRange QuestionField { get; set; }

        
        public List<IdeationQuestionVM> ideationQuestionVMs { get; set; }
     
        
      
    }

    public class IdeationQuestionVM
    {
        public String question { get; set; }              
        
    }

//    public class FieldRange
//    {
//        public int Minimum { get; set; }
//        public int Maximum { get; set; }
//    }
}