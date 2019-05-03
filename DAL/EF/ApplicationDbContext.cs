using System;
using System.Collections.Generic;
using System.Text;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string> {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        
        #region Sets
        // Fields 
        public DbSet<Field> fields { get; set; }
        public DbSet<TextField> textFields { get; set; }
        public DbSet<ImageField> imageFields { get; set; }
        public DbSet<MapField> mapFields { get; set; }
        public DbSet<QuestionField> questionFields { get; set; }
        public DbSet<VideoField> videoFields { get; set; }
        // Likes
        public DbSet<Like> likes { get; set; }
        public DbSet<IdeaLike> ideaLikes { get; set; }
        public DbSet<ProjectLike> projectLikes { get; set; }
        public DbSet<ReactionLike> answerLikes { get; set; }
        public DbSet<IotVote> iotLikes { get; set; }

        //Project
        public DbSet<Project> projects { get; set; }
        public DbSet<Phase> phases { get; set; }
        
        //Ideation
        public DbSet<Ideation> ideations { get; set; }
        public DbSet<IdeationQuestion> ideationQuestions { get; set; }
        public DbSet<Idea> ideas { get; set; }
        public DbSet<Reaction> answers { get; set; }
        
        //Questionnaire 
        public DbSet<Questionnaire> questionnaires { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Option> options { get; set; }
        public DbSet<QuestionUser> questionUsers { get; set; }

        //Iotset
        public DbSet<IotSetup> iotSetups { get; set; }
        
        //User
        public DbSet<User> users { get; set; }
        #endregion
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }   
    }
}