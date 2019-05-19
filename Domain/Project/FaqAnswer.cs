using System.ComponentModel.DataAnnotations;
using DAL.EF;

namespace Domain
{
    public class FaqAnswer
    {
        [Key]
        public int id { get; set; }
        public string Answer { get; set; }
        public ApplicationUser User { get; set; }
        public Faq Faq { get; set; }
    }
}