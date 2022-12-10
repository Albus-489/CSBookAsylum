using AutoMapper;
using MediatR;
using Project3.App.WorkWithModel.PostDir.GetList;
using Project3.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.App.WorkWithModel.PostDir.GetById;

namespace Project3.App.WorkWithModel.PostDir.AddPost
{
    public class AddPostHandler //: IRequestHandler<AddNewPost, PostDTO>
    {
        private readonly IDbContext _context;
        private readonly IMapper _mapper;

        public AddPostHandler(IDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //public async Task<PostDTO> Handle(AddNewPost request, CancellationToken cancellationToken)
        //{
        //    //_context.Posts.AddAsync(PostDTO)

        //    //return new PostDTO() 
        //    //{ 
        //    //    Id = value.Id, 
        //    //    text = value.text 
        //    //};
        //}
    }
}
