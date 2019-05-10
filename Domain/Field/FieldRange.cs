using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class FieldRange
    {
        [Required]
        public int FieldRangeId { get; set; }
        public int Maximum { get; set; }
        public int Minimum { get; set; }
    }
}