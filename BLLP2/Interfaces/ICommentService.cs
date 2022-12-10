using BLLP2.DTO.Req;
using BLLP2.DTO.Res;

namespace BLLP2.Interfaces
{
    public interface ICommentService
    {
        Task AddAsync(CommentReqDTO commentRequestDto);
        Task UpdateAsync(CommentReqDTO commentRequestDto);
        Task DeleteAsync(int id);
        Task<IEnumerable<CommentResDTO>> GetAllAsync();
        Task<CommentResDTO> GetByIdAsync(int id);
    }
}
