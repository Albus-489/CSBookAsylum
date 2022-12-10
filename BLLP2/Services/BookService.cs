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
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAsync(BookReqDTO bookRequestDto)
        {
            var item = _mapper.Map<BookReqDTO, Books>(bookRequestDto);
            await _unitOfWork.Books.AddAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Authors.RemoveAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookResDTO>?> GetAllAsync()
        {
            var results = await _unitOfWork.Books.GetAllAsync();
            return results?.Select(_mapper.Map<Books, BookResDTO>);
        }

        public async Task<BookResDTO> GetByIdAsync(int id)
        {
            var result = await _unitOfWork.Books.GetByIdAsync(id);
            return _mapper.Map<Books,BookResDTO>(result);
        }

        public async Task UpdateAsync(BookReqDTO bookRequestDto)
        {
            var item = _mapper.Map<BookReqDTO, Books>(bookRequestDto);
            await _unitOfWork.Books.UpdateAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
