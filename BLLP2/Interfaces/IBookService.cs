using BLLP2.DTO.Req;
using BLLP2.DTO.Res;

namespace BLLP2.Interfaces
{
    public interface IBookService
    {
        Task AddAsync(BookReqDTO bookRequestDto);
        Task UpdateAsync(BookReqDTO bookRequestDto);
        Task DeleteAsync(int id);
        Task<IEnumerable<BookResDTO>> GetAllAsync();
        Task<BookResDTO> GetByIdAsync(int id);
    }
}
