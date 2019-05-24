using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Xml.Linq;
using Domain;
using System.Web;
using D.UI.MVC.Models.Fields;
using DAL.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace D.UI.MVC.Models.Ideas
{
    
    public class IdeaVM 
    {
        public ApplicationUser _user { get; set; }
        public int IdeaId { get; set; }
        
        public string IdeaTitle { get; set; }
        public int ideationId { get; set; }
        public bool disapproved { get; set; }
        public String[] ideationQuestion { get; set; }
        
        public int amountOfLikes { get; set; }
        public bool verified { get; set; }
        public List<Reaction> reactions { get; set; }

        
        public int ideaViewModelId { get; set; }
        public string name { get; set; }
        //  public ICollection<FieldViewModel> fields { get; set; }

        //public IFormFile[] Files { get; set; }
       
        public IFormCollection Files { get; set; }
        public List<ImageFieldVm> ImageFieldVms { get; set; }

        public List<TextFieldVm> TextFieldVms { get; set; }

        public List<VideoFieldVm> VideoFieldVms { get; set; }
        
        public List<QuestionFieldVm> QuestionFieldVms { get; set; }
        
        public List<MapFieldVm> MapFieldVms { get; set; }
    }

//    public class IdeasVM
//    {
//        public ICollection<Idea> ideas { get; set; }
//        public ICollection<TextField> fields { get; set; }
//        public ICollection<Reaction> reactions { get; set; }
//        public ICollection<ApplicationUser> Users { get; set; }
//
//        public ICollection<IdeaVM> IdeaVms { get; set; }
//        public int IdeationId { get; set; }
//    }
    public class IdeaListItem
    {
        public int IdeaId;
        public String Base64Image { get; set; }
        public String IdeaTitle { get; set; }
        public String UserName { get; set; }
        public int LikeCount { get; set; }
        public int ReactionCount { get; set; }
       
    }
    public class IdeasVM
    {
        public ICollection<Idea> ideas { get; set; }
        public ICollection<TextField> fields { get; set; }
        public ICollection<Reaction> reactions { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }

        public ICollection<IdeaVM> IdeaVms { get; set; }
        public int IdeationId { get; set; }
    }
}