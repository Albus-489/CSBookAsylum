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
    public class ThemeMessagesService : IThemeMessageServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;

        public ThemeMessagesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
         
        public async Task<IEnumerable<ThemeMessageResDTO>> GetAllThemeMessages()
        {
            var result = await _unitOfWork.ThemeMessageRepo.GetAllAsync();
            return result?.Select(_mapper.Map<ThemeMessage, ThemeMessageResDTO>);
        }

        public async Task AddAsync(ThemeMessageReqDTO themeMessage)
        {
            var result = _mapper.Map<ThemeMessageReqDTO, ThemeMessage>(themeMessage);
            await _unitOfWork.ThemeMessageRepo.AddAsync(result);
            _unitOfWork.Commit();
        }

        public async Task DeleteAsync(long id)
        {
            await _unitOfWork.ThemeMessageRepo.DeleteAsync(id);
            _unitOfWork.Commit();
        }

        public async Task UpdateAsync(ThemeMessageReqDTO newMessage)
        {
            var result = _mapper.Map<ThemeMessageReqDTO, ThemeMessage>(newMessage);
            await _unitOfWork.ThemeMessageRepo.ReplaceAsync(result);
            _unitOfWork.Commit();
        }
    }
}
