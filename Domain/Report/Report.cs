using System;
using System.ComponentModel.DataAnnotations;
using DAL.EF;

namespace Domain
{
    public class Report
    {
        public int id { get; set; }
        [MaxLength(255)]
        public string reportMessage { get; set; }
        public DateTime dateSubmitted { get; set; }
        public Idea idea { get; set; }
        public Reaction reaction { get; set; }
        public ApplicationUser user { get; set; }
    }
}