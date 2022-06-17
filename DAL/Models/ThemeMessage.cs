namespace Project1.DAL.Models
{
    public class ThemeMessage
    {
        public int id { get; set; }
        public string text { get; set; }    
        public int? rating { get; set; }
        public string? mssgPicture { get; set; }
        public int theme  { get; set; }
        public Themes Thme { get; set; }
        public string user { get; set; }
        public AspNetUsers Usr { get; set; }
    }
}
