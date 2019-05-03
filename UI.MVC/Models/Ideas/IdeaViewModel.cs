using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Xml.Linq;
using Domain;
using System.Web;

using Microsoft.AspNetCore.Http;

namespace UI.MVC.Models.Ideas
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
    public class IdeaViewModel
    {
        public int ideationId { get; set; }
        public String[] ideationQuestion { get; set; }
        
        public int ideaViewModelId { get; set; }
        public string name { get; set; }
      //  public ICollection<FieldViewModel> fields { get; set; }
        public TextFieldViewModel textFieldViewModel { get; set; }
        public ImageFieldViewModel imageFieldViewModel { get; set; }
        public VideoFieldViewModel videoFieldViewModel { get; set; }
        public MapFieldViewModel    mapFieldViewModel { get; set; }
        

        
    //  public FieldViewModel fieldViewModel { get; set; }
    
    
        
        
    }

    public class FieldViewModel
    {
        public int fieldViewModelId { get; set; }
        public Boolean isRequired { get; set; }

    }

    public class TextFieldViewModel : FieldViewModel
    {
        public String text { get; set; }
        public bool IsAnswered => !string.IsNullOrWhiteSpace(text);

        
    }

    public class ImageFieldViewModel : FieldViewModel
    {
        //public string imageName { get; set; }
       // [Required, Microsoft.Web.Mvc.FileExtensions(Extensions = "jpeg",ErrorMessage = "Specify a jpeg file.")]
       
        public string imageName { get; set; }
        public IFormFile imageFile { get; set; }

        

        public string GetImageData()
        {
            Byte[] data;
            using (var reader = imageFile.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                {    
                    reader.CopyTo(stream);
                    data = stream.ToArray();

                }    
                                        
            }
            
            var base64 = Convert.ToBase64String(data);
            return String.Format("data:image/png;base64,{0}", base64);
        }
        
    }

    public class VideoFieldViewModel : FieldViewModel
    {
        public string videoName { get; set; }
        public IFormFile videoFile { get; set; }
    }

    public class MapFieldViewModel : FieldViewModel
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class QuestionFieldViewModel : ImageFieldViewModel
    {
        
        
        
    }
    
    
        
}