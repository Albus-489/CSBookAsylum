using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Domain.Entities
{
    public class TagsToPosts
    {
        public int post_id { get; set; }
        public int tags_id { get; set;}

        public Posts posts { get; set; }
        public Tags tags { get; set; }
    }
}
