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

        
        public List<IdeationQuestionVM> IdeationQuestionVMs { get; set; }
     
        
      
    }

    public class IdeationQuestionVM
    {
        public String Question { get; set; }              
        
    }

    public class IdeationPageVM
    {
        public Boolean AdminOnly { get; set; }
        public int IdeationId { get; set; }
        public List<string> IdeationQuestions { get; set; }
        public List<IdeaListItemVM> IdeaListItemVms { get; set; }
        public int projectId { get; set; }
    }
    public class IdeaListItemVM
    {
        public int IdeaId;
        public String Base64Image { get; set; }
        public String IdeaTitle { get; set; }
        public String UserName { get; set; }
        public int LikeCount { get; set; }
        public int ReactionCount { get; set; }
    }

//    public class FieldRange
//    {
//        public int Minimum { get; set; }
//        public int Maximum { get; set; }
//    }
}