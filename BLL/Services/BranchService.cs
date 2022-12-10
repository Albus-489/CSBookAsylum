using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;
using Project1.BLL.Interfaces;
using Project1.DAL.Interfaces;
using Project1.DAL.Models;

namespace Project1.BLL.Services
{
    public class BranchService : IBranchesServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;

        public BranchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
         
        public async Task<IEnumerable<BranchesResDTO>> GetAllBranches()
        {
            var result = await _unitOfWork.BranchesRepository.GetAllAsync();
            return result?.Select(_mapper.Map<Branches, BranchesResDTO>);
        }

        public async Task AddAsync(BranchesReqDTO branch)
        {
            var result = _mapper.Map<BranchesReqDTO, Branches>(branch);
            await _unitOfWork.BranchesRepository.AddAsync(result);
            _unitOfWork.Commit();
        }

        public async Task UpdateAsync(BranchesReqDTO branch)
        {
            var result = _mapper.Map<BranchesReqDTO, Branches>(branch);
            await _unitOfWork.BranchesRepository.ReplaceAsync(result);
            _unitOfWork.Commit();
        }

        public async Task DeleteAsync(long id)
        {
            await _unitOfWork.BranchesRepository.DeleteAsync(id);
            _unitOfWork.Commit();
        }
    }
}
