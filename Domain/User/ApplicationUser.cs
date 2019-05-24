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
        
        public ICollection<QuestionUser> QuestionnaireAnswer { get; set; }
        public ICollection<Idea> Ideas { get; set; }
        public ICollection<Reaction> Reactions { get; set; }
        public ICollection<IdeaLike> IdeaLikes { get; set; }
        public ICollection<ProjectLike> ProjectLikes { get; set; }
        public ICollection<ReactionLike> ReactionLikes { get; set; }
        public ICollection<IotVote> IotVotes { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<Faq> Faqs { get; set; }
        public ICollection<FaqAnswer> FaqAnswers { get; set; }
        public bool Blocked { get; set; }
    }
}