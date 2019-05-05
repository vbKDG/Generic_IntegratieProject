using System.ComponentModel.DataAnnotations;

namespace DAL.EF
{
    public class Organisation
    {
        public string Id { get; set; }
        public string OrganisationName { get; set; }
        public string OrganisationEventInput { get; set; }
        [Required]
        public ApplicationUser ApplicationUser { get; set; }
    }
}