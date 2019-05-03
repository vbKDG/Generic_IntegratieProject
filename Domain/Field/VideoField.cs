namespace Domain
{
    public class VideoField : Field
    {
        public int length { get; set; }
        public string quality { get; set; }
        public byte[] videoData { get; set; }
        
    }
}