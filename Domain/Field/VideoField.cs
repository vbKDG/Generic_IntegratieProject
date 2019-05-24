using System;

namespace Domain
{
    public class VideoField : Field
    {
        public int length { get; set; }
        public string quality { get; set; }
        public byte[] VideoData { get; set; }
        
        public string GetVideoString()
        {
           
            
            var base64 = Convert.ToBase64String(VideoData);
            return String.Format("data:video/mp4;base64,{0}", base64);
        }
        
    }
}