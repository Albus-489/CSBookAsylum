using Project3.App.Mapping;
using Project3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.App.WorkWithModel.PostDir.GetList
{
    public class PostDTO: IMapFrom<Posts>
    {
        public int Id { get; set; }
        public string text { get; set; }
    }
}
