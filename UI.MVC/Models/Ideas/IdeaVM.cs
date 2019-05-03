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
        public TextFieldVm textFieldVM { get; set; }
        public ImageFieldVm imageFieldVM { get; set; }
        public VideoFieldVm videoFieldVM { get; set; }
        public MapFieldVm    mapFieldVM { get; set; }
        

        
    //  public FieldViewModel fieldViewModel { get; set; }
    
    
        
        
    }

   
    
    
        
}