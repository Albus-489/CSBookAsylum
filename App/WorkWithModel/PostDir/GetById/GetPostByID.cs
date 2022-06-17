using MediatR;
using Project3.App.WorkWithModel.PostDir.GetList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.App.WorkWithModel.PostDir.GetById
{
    public class GetPostByID: IRequest<PostDTO>
    {
        public int Id { get; }
        public GetPostByID(int id)
        {
            Id = id;
        }

    }
}
