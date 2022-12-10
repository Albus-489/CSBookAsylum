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
    public class ThemesService : IThemesServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;

        public ThemesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ThemesResDTO>> GetAllThemes()
        {
            var result = await _unitOfWork.ThemesRepository.GetAllAsync();
            return result?.Select(_mapper.Map<Themes, ThemesResDTO>);
        }

        public async Task AddAsync(ThemesReqDTO theme)
        {
            var result = _mapper.Map<ThemesReqDTO, Themes>(theme);
            await _unitOfWork.ThemesRepository.AddAsync(result);
            _unitOfWork.Commit();
        }

        public async Task UpdateAsync(ThemesReqDTO theme)
        {
            throw new NotImplementedException(); var result = _mapper.Map<ThemesReqDTO, Themes>(theme);
            await _unitOfWork.ThemesRepository.ReplaceAsync(result);
            _unitOfWork.Commit();
        }

        public async Task DeleteAsync(long id)
        {
            await _unitOfWork.ThemesRepository.DeleteAsync(id);
            _unitOfWork.Commit();
        }
    }
}
