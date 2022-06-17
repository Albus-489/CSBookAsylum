using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Entities
{
    public class Collections : EntityBase
    {
        public string name { get; set; }
        public string userID { get; set; }
        public Users user { get; set; }

        public int? rating { get; set; }

        public IList<Books> books { get; set; } = new List<Books>();
    }
}
