using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLP2.DTO.Res
{
    public class AuthorResDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? birth { get; set; }
        public DateTime? death { get; set; }
        public int? rating { get; set; }
        public string? bio { get; set; }
    }
}
