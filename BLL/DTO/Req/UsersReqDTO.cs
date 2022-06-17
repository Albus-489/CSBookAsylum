using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.DAL.Models;

namespace Project1.BLL.DTO.Req
{
    public class UsersReqDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? rating { get; set; }
        public string? profilePicture { get; set; }
        public string? telegram { get; set; }
        public string? status { get; set; }
    }
}
