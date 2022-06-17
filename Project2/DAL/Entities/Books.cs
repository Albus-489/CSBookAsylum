using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Entities
{
    public class Books : EntityBase
    {
        public string name { get; set; }
        public string? genre { get; set; }
        public DateTime? created { get; set; }
        public int? rating { get; set; }
        public string? descriptionInfo { get; set; }
        public Authors? author { get; set; }
        public int? authorId { get; set; }

        public IList<Comments>? comments { get; set; }
        public IList<Collections>? collections { get; set; } = new List<Collections>();

    }
}
