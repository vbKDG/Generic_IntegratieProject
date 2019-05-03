using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;


namespace Domain
{
    public class ImageField : Field
    {
       public string imageName { get; set; }
       public byte[] imageData { get; set; }
      
    
        
       

    }
}