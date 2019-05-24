using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace D.UI.MVC.Models.Fields
{
    public class FieldVM
    {
        public int FieldViewModelId { get; set; }
        public Boolean IsRequired { get; set; }

    }

    public class TextFieldVm : FieldVM
    {
        public String Text { get; set; }
        public bool IsAnswered => !string.IsNullOrWhiteSpace(Text);


    }

    public class ImageFieldVm : FieldVM
    {


        public string ImageName { get; set; }

        [Display(Name = "Choose Image")] public IFormCollection ImageFile { get; set; }
        //  public IFormFile[] imageFiles { get; set; }

        public String Base64Image { get; set; }

        public string GetImageData()
        {
            Byte[] data;
            using (var reader = ImageFile.Files[0].OpenReadStream())
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
        public string VideoName { get; set; }
        public IFormCollection VideoFile { get; set; }
        
        public String Base64Video { get; set; }

    }

    public class MapFieldVm : FieldVM
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class QuestionFieldVm : FieldVM
    {
        public int QuestionFieldVMId { get; set; }
        public Question Question { get; set; }
        public String QuestionType { get; set; }
        public String QuestionText { get; set; }

        public String[] Options { get; set; }
       
    }
}
       
       