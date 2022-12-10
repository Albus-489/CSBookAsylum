using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLP2.DTO.Res
{
    public class CollectionResDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string? user_id { get; set; }

        public int? rating { get; set; }
    }
}
