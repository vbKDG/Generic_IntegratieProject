using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace D.UI.MVC.Models.Fields
{
    public class FieldVM
    {
        public int fieldViewModelId { get; set; }
        public Boolean isRequired { get; set; }

    }

    public class TextFieldVm : FieldVM
    {
        public String text { get; set; }
        public bool IsAnswered => !string.IsNullOrWhiteSpace(text);

        
    }

    public class ImageFieldVm : FieldVM
    {
        //public string imageName { get; set; }
        // [Required, Microsoft.Web.Mvc.FileExtensions(Extensions = "jpeg",ErrorMessage = "Specify a jpeg file.")]
       
        public string imageName { get; set; }
        [Display(Name ="Choose Image")]
        public IFormFile imageFile { get; set; }
        public IFormFile[] imageFiles { get; set; }

        

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

    public class VideoFieldVm : FieldVM
    {
        public string videoName { get; set; }
        public IFormFile videoFile { get; set; }
    }

    public class MapFieldVm : FieldVM
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class QuestionFieldVm : ImageFieldVm
    {
        
        
        
    }
}