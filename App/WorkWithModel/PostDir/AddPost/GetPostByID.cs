using MediatR;
using Project3.App.WorkWithModel.PostDir.GetList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.App.WorkWithModel.PostDir.GetById
{
    public class AddNewPost: IRequest<PostDTO>
    {
        public int Id { get; set; }
        public string text { get; set; }
        public AddNewPost(int id, string Text)
        {
            Id = id;
            text = Text;
        }

    }
}
