using Microsoft.AspNetCore.Mvc;

namespace WEBAPI__PR2.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }
        public string Client_URL { get; set; }
    }
}
