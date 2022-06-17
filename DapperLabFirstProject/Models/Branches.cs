namespace DapperLabFirstProject.Models
{
    public class Branches
    {
        public int id { get; set; }
        public Users creator { get; set; }
        public string name { get; set; }
        public string headerPicture { get; set; }
    }
}
