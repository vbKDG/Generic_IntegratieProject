using System;

namespace UI.MVC.Models.Ideations
{
    public class IdeationVM
    {
        public String link { get; set; }
        
        public int amountTextFields { get; set; }
        public int amountImageFields { get; set; }
        public int amountMapFields { get; set; }
        public int amountVideoFields { get; set; }
        
        public IdeationQuestionVM[] ideationQuestionVMs { get; set; }
    }

    public class IdeationQuestionVM
    {
        public String question { get; set; }
        
        
    }
}