using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.DAL.Models;

namespace Project1.BLL.DTO.Req
{
    public class ThemesReqDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? message { get; set; } // message obj collection
        public string? image { get; set; }

        public int branch { get; set; }
        public Branches Brnch { get; set; }
        public string creator { get; set; }
    }
}
