using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Entities
{
    public class Comments : EntityBase
    {
        public string text { get; set; }
        public int? rating { get; set; }
        public int? book_id { get; set; }
        public Books? book { get; set; }
        public string? user_id { get; set; }
    }
}
