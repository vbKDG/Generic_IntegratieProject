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
        
        public int IdeationId { get; set; }
        public bool Disapproved { get; set; }
        public String[] IdeationQuestion { get; set; }
        
        public int AmountOfLikes { get; set; }
        public bool Verified { get; set; }
        public List<Reaction> Reactions { get; set; }
        public string IdeaTitle { get; set; }

        
        public int IdeaViewModelId { get; set; }
        public string Name { get; set; }
        //  public ICollection<FieldViewModel> fields { get; set; }

        //public IFormFile[] Files { get; set; }
       
        public IFormCollection Files { get; set; }
        public List<ImageFieldVm> ImageFieldVms { get; set; }

        public List<TextFieldVm> TextFieldVms { get; set; }

        public List<VideoFieldVm> VideoFieldVms { get; set; }
        
        public List<QuestionFieldVm> QuestionFieldVms { get; set; }
        
        public List<MapFieldVm> MapFieldVms { get; set; }
        
        public int ImageFieldVMMin { get; set; }
        public int TextFieldVMMin { get; set; }
        public int VideoFieldVMMin { get; set; }
        public int MapFieldVMMin { get; set; }
        public int QuestionVMMin { get; set; }

    }

    public class IdeasVM
    {
        public ICollection<Idea> ideas { get; set; }
        public ICollection<TextField> fields { get; set; }
        public ICollection<Reaction> reactions { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
        public int IdeationId { get; set; }
    }
    
   

//    public class IdeationVM
//    {
//      
//        
//    }
}