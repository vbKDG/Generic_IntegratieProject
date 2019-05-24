using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.EF;

namespace Domain
{
    public class Faq
    {
        [Key]
        public int FaqId { get; set; }
        public string Question { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<FaqAnswer> Answers { get; set; }
    }
}