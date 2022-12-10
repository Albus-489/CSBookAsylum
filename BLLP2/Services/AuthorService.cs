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
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAsync(AuthorReqDTO authorRequestDto)
        {
            var item = _mapper.Map<AuthorReqDTO, Authors>(authorRequestDto);
            await _unitOfWork.Authors.AddAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Authors.RemoveAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<AuthorResDTO>?> GetAllAsync()
        {
            var results = await _unitOfWork.Authors.GetAllAsync();
            return results?.Select(_mapper.Map<Authors, AuthorResDTO>);
        }

        public async Task<AuthorResDTO> GetByIdAsync(int id)
        {
            var result = await _unitOfWork.Authors.GetByIdAsync(id);
            return _mapper.Map<Authors, AuthorResDTO>(result);
        }

        public async Task UpdateAsync(AuthorReqDTO authorRequestDto)
        {
            var item = _mapper.Map<AuthorReqDTO, Authors>(authorRequestDto);
            await _unitOfWork.Authors.UpdateAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
