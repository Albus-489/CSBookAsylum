using Project3.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Domain.Entities
{
    public class Tags : EntityNeeds
    {
        public string name { get; set; }
        public IList<TagsToPosts> tagstoposts { get; set; }
    }
}
