using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace DAL.EF
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [PersonalData]
        [DataType(DataType.Text)]
        [MaxLength(15)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [PersonalData]
        [DataType(DataType.Text)]
        [MaxLength(2)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
        public string Age { get; set; }

        [PersonalData]
        [DataType(DataType.Text)]
        [MaxLength(1)]
        public string Gender { get; set; }
        
        public Organisation Organisation { get; set; }
        
        public ICollection<QuestionUser> questionnaireAnswer { get; set; }
        public ICollection<Idea> ideas { get; set; }
        public ICollection<Reaction> reactions { get; set; }
        public ICollection<IdeaLike> ideaLikes { get; set; }
        public ICollection<ProjectLike> projectLikes { get; set; }
        public ICollection<ReactionLike> reactionLikes { get; set; }
        public ICollection<IotVote> iotVotes { get; set; }
    }
}