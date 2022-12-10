using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLP2.DTO.Res
{
    public class BookResDTO
    {

        public int Id { get; set; }
        public string name { get; set; }
        public string? genre { get; set; }
        public DateTime? created { get; set; }
        public int? rating { get; set; }
        public string? description { get; set; }
        public string? image { get; set; }
    }
}
