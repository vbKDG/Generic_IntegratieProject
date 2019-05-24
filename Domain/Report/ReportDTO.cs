using System;
using System.ComponentModel.DataAnnotations;
using Domain;

namespace D.UI.MVC.Models
{
    public class ReportDTO
    {
        public int ReportDtoId { get; set; }
        [MaxLength(255)]
        public string ReportMessage { get; set; }
        public DateTime DateSubmitted { get; set; }
        public int IdeaId { get; set; }
        public int ReactionId { get; set; }
    }
}