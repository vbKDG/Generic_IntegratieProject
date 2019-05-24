using System;
using System.ComponentModel.DataAnnotations;
using DAL.EF;

namespace Domain
{
    public class Report
    {
        public int ReportId { get; set; }
        [MaxLength(255)]
        public string ReportMessage { get; set; }
        public DateTime DateSubmitted { get; set; }
        public Idea Idea { get; set; }
        public Reaction Reaction { get; set; }
        public ApplicationUser User { get; set; }
        public bool SendToAdmin { get; set; }
    }
}