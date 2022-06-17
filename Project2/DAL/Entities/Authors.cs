using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Entities
{
    public class Authors : EntityBase
    {
        public string name { get; set; }
        public DateTime? birth { get; set; }
        public DateTime? death { get; set; }
        public int? rating { get; set; } 
        public string? bio { get; set; }

        public IList<Books> books { get; set; }
    }
}
