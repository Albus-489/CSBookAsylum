using Project2.DAL.Entities;
using Project3.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Domain.Entities
{
    public class Posts : EntityNeeds
    {
        public string text { get; set; }
        public int? likes { get; set; }
        public string creator { get; set; }
        //public Users user_creator { get; set; }
        public byte[]? image { get; set; }
        public IList<ComentsToPost> commentstopost { get; set; }
        public IList<TagsToPosts> tags { get; set; }

    }
}
