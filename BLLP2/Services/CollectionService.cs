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
    public class CollectionService : ICollectionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CollectionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAsync(CollectionReqDTO CollectionRequestDto)
        {
            var item = _mapper.Map<CollectionReqDTO, Collections>(CollectionRequestDto);
            await _unitOfWork.Collections.AddAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Authors.RemoveAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<CollectionResDTO>?> GetAllAsync()
        {
            var results = await _unitOfWork.Collections.GetAllAsync();
            return results?.Select(_mapper.Map<Collections, CollectionResDTO>);
        }

        public async Task<CollectionResDTO> GetByIdAsync(int id)
        {
            var result = await _unitOfWork.Collections.GetByIdAsync(id);
            return _mapper.Map<Collections, CollectionResDTO>(result);
        }

        public async Task UpdateAsync(CollectionReqDTO CollectionRequestDto)
        {
            var item = _mapper.Map<CollectionReqDTO, Collections>(CollectionRequestDto);
            await _unitOfWork.Collections.UpdateAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
