using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Xml.Linq;
using Domain;
using System.Web;
using D.UI.MVC.Models.Fields;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace D.UI.MVC.Models.Ideas
{
  /*  public static class IdeaExtensions
    {
        public static IdeaViewModel ToViewModel(this Idea idea)
        {
            var model = new IdeaViewModel
            {
                ideaViewModelId = idea.ideaId,
                
                
            };
        }
    }*/
    public class IdeaVM 
    {

       
        
        public int ideationId { get; set; }
        public String[] ideationQuestion { get; set; }
        
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

//        //public VideoFieldVm[] VideoFieldVms { get; set; }
//        //public MapFieldVm[] MapFieldVms { get; set; }
//        public TextFieldVm textFieldVM { get; set; }
//      //  public ImageFieldVm imageFieldVM { get; set; }
//        public VideoFieldVm videoFieldVM { get; set; }
//        public MapFieldVm    mapFieldVM { get; set; }
//        public QuestionFieldVm QuestionFieldVm { get; set; }
        

        
    //  public FieldViewModel fieldViewModel { get; set; }

  
    }

    public class IdeasVM
    {
        public ICollection<Idea> ideas { get; set; }
        public ICollection<TextField> fields { get; set; }
        public ICollection<Reaction> reactions { get; set; }
        public int IdeationId { get; set; }
    }

   
    
    
        
}