using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;


namespace Domain
{
    public class ImageField : Field
    {
       public string ImageName { get; set; }
     //  public byte[] imageData { get; set; }
      
       public string ImageData { get; set; }

       
//       public string GetImageString()
//       {
//           
//            
//           var base64 = Convert.ToBase64String(imageData);
//           return String.Format("data:image/png;base64,{0}", base64);
//       }
        
       

    }
}