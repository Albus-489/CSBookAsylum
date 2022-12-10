using BLLP2.DTO.Req;
using BLLP2.DTO.Res;

namespace BLLP2.Interfaces
{
    public interface IAuthorService
    {
        Task AddAsync(AuthorReqDTO authorRequestDto);
        Task UpdateAsync(AuthorReqDTO authorRequestDto);
        Task DeleteAsync(int id);
        Task<IEnumerable<AuthorResDTO>> GetAllAsync();
        Task<AuthorResDTO> GetByIdAsync(int id);
    }
}
