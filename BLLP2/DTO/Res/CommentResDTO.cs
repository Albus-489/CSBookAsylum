using Project2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLP2.DTO.Res
{
    public class CommentResDTO
    {

        public int Id { get; set; }
        public string text { get; set; }
        public int rating { get; set; }
        public int book_id { get; set; }
        public string? user_id { get; set; }
    }
}
