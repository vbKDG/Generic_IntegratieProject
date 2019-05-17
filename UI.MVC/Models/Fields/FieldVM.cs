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


        public string imageName { get; set; }

        [Display(Name = "Choose Image")] public IFormCollection imageFile { get; set; }
        //  public IFormFile[] imageFiles { get; set; }



        public string GetImageData()
        {
            Byte[] data;
            using (var reader = imageFile.Files[0].OpenReadStream())
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
        public IFormCollection VideoFile { get; set; }
    }

    public class MapFieldVm : FieldVM
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class QuestionFieldVm : FieldVM
    {
        public int id { get; set; }
        public String questionType { get; set; }
        public String question { get; set; }

        public String[] Options { get; set; }
       
    }
}
       
       