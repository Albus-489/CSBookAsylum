using AutoMapper;
using BLLP2.DTO.Req;
using BLLP2.DTO.Res;
using BLLP2.Interfaces;
using Project2.DAL.Interfaces;
using Project2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLP2.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAsync(CommentReqDTO commentRequestDto)
        {
            var item = _mapper.Map<CommentReqDTO, Comments>(commentRequestDto);
            await _unitOfWork.Comments.AddAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Authors.RemoveAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<CommentResDTO>?> GetAllAsync()
        {
            var results = await _unitOfWork.Comments.GetAllAsync();
            return results?.Select(_mapper.Map<Comments, CommentResDTO>);
        }

        public async Task<CommentResDTO> GetByIdAsync(int id)
        {
            var result = await _unitOfWork.Comments.GetByIdAsync(id);
            return _mapper.Map<Comments, CommentResDTO>(result);
        }

        public async Task UpdateAsync(CommentReqDTO commentRequestDto)
        {
            var item = _mapper.Map<CommentReqDTO, Comments>(commentRequestDto);
            await _unitOfWork.Comments.UpdateAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
