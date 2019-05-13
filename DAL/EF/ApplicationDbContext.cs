using System;
using System.Collections.Generic;
using System.Text;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string> {
        public ApplicationDbContext()          
        {
            
        }
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//            : base(options)
//        {
//            
            
            
    //    }
        #region Sets
        // Fields 
        public DbSet<FieldRange> FieldRanges { get; set; }
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
        public DbSet<Reaction> reactions { get; set; }
        
        //Questionnaire 
        public DbSet<Questionnaire> questionnaires { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Option> options { get; set; }
        public DbSet<QuestionUser> questionUsers { get; set; }

        //Iotset
        public DbSet<IotSetup> iotSetups { get; set; }
        
        //Identity
        public DbSet<Organisation> Organisations { get; set; }
        
        #endregion
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
            
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  

            builder.Entity<Organisation>().Property<string>("ApplicationUserFK_shadow");
            builder.Entity<Organisation>().HasOne(sm => sm.ApplicationUser)
                .WithOne(fm => fm.Organisation)
                .HasForeignKey<Organisation>("ApplicationUserFK_shadow");
        }

        public override int SaveChanges()
        {
        
            if (delaySave)
                return -1;
            return base.SaveChanges();






        }
        private readonly bool delaySave = false;

        public ApplicationDbContext(bool isUnitOfWorkPresent) : this()
        {
            delaySave = isUnitOfWorkPresent;
        }
        
        internal int CommitChanges() // in combinatie met override van 'SaveChanges' met UoW-pattern implementatie!
        {
            if (delaySave)
            {
                Helper.PrintDbContextTrackedEntitiesStates(this, "STATES BEFORE CommitChanges() (TO DB)");
            
                int infectedRecords = base.SaveChanges();
            
                Helper.PrintDbContextTrackedEntitiesStates(this, "STATES AFTER CommitChanges() (TO DB)");            
            
                return infectedRecords;
            }
            
            throw new InvalidOperationException("No UnitOfWork present, use SaveChanges instead");
        }
        

     
    }
}