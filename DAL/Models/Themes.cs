namespace Project1.DAL.Models
{
    public class Themes
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? message { get; set; } // message obj collection
        public string? image { get; set; }
        
        public int branch { get; set; }
        public Branches Brnch { get; set; }
        public string creator { get; set; }

    }
}
