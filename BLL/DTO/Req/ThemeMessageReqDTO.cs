using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.DAL.Models;

namespace Project1.BLL.DTO.Req
{
    public class ThemeMessageReqDTO
    {
        public int id { get; set; }
        public string text { get; set; }
        public int? rating { get; set; }
        public string? image { get; set; }
        public int theme { get; set; }
        public Themes Thme { get; set; }
        public string user { get; set; }
    }
}
