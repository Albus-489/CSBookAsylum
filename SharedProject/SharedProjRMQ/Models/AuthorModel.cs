using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProjRMQ.Models
{
    public class AuthorModel
    {
        public string Id { get; set; }
        public DateTime? birth { get; set; }
        public DateTime? death { get; set; }
        public int? rating { get; set; }
        public string? bio { get; set; }
    }
}
