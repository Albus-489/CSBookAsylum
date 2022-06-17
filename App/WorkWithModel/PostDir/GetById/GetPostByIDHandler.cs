using AutoMapper;
using MediatR;
using Project3.App.WorkWithModel.PostDir.GetList;
using Project3.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.App.WorkWithModel.PostDir.GetById
{
    public class GetPostByIDHandler : IRequestHandler<GetPostByID, PostDTO>
    {
        private readonly IDbContext _context;
        private readonly IMapper _mapper;

        public GetPostByIDHandler(IDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PostDTO> Handle(GetPostByID request, CancellationToken cancellationToken)
        {
            var value = _context.Posts.FirstOrDefault(x => x.Id == request.Id);

            return new PostDTO() 
            { 
                Id = value.Id, 
                text = value.text 
            };
        }
    }
}
