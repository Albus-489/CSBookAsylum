﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLP2.DTO.Req
{
    public class BookReqDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string? genre { get; set; }
    }
}
