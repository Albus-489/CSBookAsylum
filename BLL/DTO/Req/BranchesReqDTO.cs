using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.DAL.Models;

namespace Project1.BLL.DTO.Req
{
    public class BranchesReqDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? image { get; set; }
        public string? description { get; set; }
        public string creator { get; set; }
    }
}
