using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.BLL.DTO.Res
{
    public class UserResDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public int Rating { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
