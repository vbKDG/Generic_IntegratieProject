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
        
        #region Sets
        // Fields 
        public DbSet<FieldRange> FieldRanges { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ImageField> ImageFields { get; set; }
        public DbSet<MapField> MapFields { get; set; }
        public DbSet<QuestionField> QuestionFields { get; set; }
        public DbSet<VideoField> VideoFields { get; set; }
        // Likes
        public DbSet<Like> Likes { get; set; }
        public DbSet<IdeaLike> IdeaLikes { get; set; }
        public DbSet<ProjectLike> ProjectLikes { get; set; }
        public DbSet<ReactionLike> ReactionLikes { get; set; }
        public DbSet<IotVote> IotLikes { get; set; }
        
        public DbSet<Report> Reports { get; set; }
        //Project
        public DbSet<Project> Projects { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Setting> Settings { get; set; }
        
        //Ideation
        public DbSet<Ideation> Ideations { get; set; }
        public DbSet<IdeationQuestion> IdeationQuestions { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        
        //Questionnaire 
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<QuestionUser> QuestionUsers { get; set; }

        //Iotset
        public DbSet<IotSetup> IotSetups { get; set; }
        
        //Identity
        public DbSet<Organisation> Organisations { get; set; }
        
        //Faq
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FaqAnswer> FaqAnswers { get; set; }
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

            builder.Entity<QuestionField>().Property<int>("QuestionFK_shadow");
            builder.Entity<QuestionField>().HasOne(q => q.Question)
                .WithOne(qf => qf.QuestionField)
                .HasForeignKey<QuestionField>("QuestionFK_shadow");

            builder.Entity<Setting>().Property<int>("ProjectFK_shadow");
            builder.Entity<Setting>().HasOne(s => s.Project)
                .WithOne(p => p.Setting)
                .HasForeignKey<Setting>("ProjectFK_shadow");
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
        
        internal int CommitChanges()
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