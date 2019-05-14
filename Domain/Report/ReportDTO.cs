using System;
using System.ComponentModel.DataAnnotations;
using Domain;

namespace D.UI.MVC.Models
{
    public class ReportDTO
    {
        public int id { get; set; }
        [MaxLength(255)]
        public string reportMessage { get; set; }
        public DateTime dateSubmitted { get; set; }
        public int ideaId { get; set; }
        public int reactionId { get; set; }
    }
}