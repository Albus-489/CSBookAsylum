using AutoMapper;
using Project1.DAL.Models;
using Project1.DAL.Interfaces;
using Project1.BLL.Interfaces;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Services
{
    public class UsersService : IUsersServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UsersService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;  
            _mapper = mapper;
        }

        public async Task<IEnumerable<UsersResDTO>> GetAllAsync()
        {
            var result = await _unitOfWork.UsersRepository.GetAllAsync();

            return result?.Select(_mapper.Map<AspNetUsers, UsersResDTO>);
        }

        public async Task<long> AddAsync(UsersReqDTO user)
        {
            var result = _mapper.Map<UsersReqDTO, AspNetUsers>(user);
            Console.WriteLine(result.FirstName);
            return await _unitOfWork.UsersRepository.AddAsync(result);
        }

        public async Task UpdateAsync(UsersReqDTO user)
        {
            var result = _mapper.Map<UsersReqDTO, AspNetUsers>(user);
            await _unitOfWork.UsersRepository.ReplaceAsync(result);
        }

        public async Task DeleteAsync(long id)
        {
            await _unitOfWork.UsersRepository.DeleteAsync(id);
        }
    }
}
