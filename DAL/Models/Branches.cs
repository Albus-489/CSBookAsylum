namespace Project1.DAL.Models
{
    public class Branches
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? headerPicture { get; set; }
        public string creator { get; set; }
        public AspNetUsers user { get; set; }
    }
}
