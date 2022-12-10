using AutoMapper;
using BLLP2.DTO;
using BLLP2.DTO.Req;
using BLLP2.DTO.Res;
using Project2.DAL.Entities;

namespace BLLP2.Configs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateAuthorMaps();
            CreateBookMaps();
            CreateCommentMaps();
            CreateCollectionMaps();
        }

        private void CreateAuthorMaps()
        {
            CreateMap<AuthorReqDTO, Authors>();
            CreateMap<Authors, AuthorResDTO>();
        }

        private void CreateBookMaps()
        {
            CreateMap<BookReqDTO, Books>();
            CreateMap<Books, BookResDTO>();
        }
        
        private void CreateCommentMaps()
        {
            CreateMap<CommentReqDTO, Comments>();
            CreateMap<Comments, CommentResDTO>();
        }

        private void CreateCollectionMaps()
        {
            CreateMap<CollectionReqDTO, Collections>();
            CreateMap<Collections, CollectionResDTO>();
        }

    }
}
