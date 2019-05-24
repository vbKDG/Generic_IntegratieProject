using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class QuestionField : Field
    {
       public Question Question { get; set; }
       
    }
}