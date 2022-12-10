using BLLP2.DTO.Req;
using BLLP2.DTO.Res;

namespace BLLP2.Interfaces
{
    public interface ICollectionService
    {
        Task AddAsync(CollectionReqDTO CollectionRequestDto);
        Task UpdateAsync(CollectionReqDTO CollectionRequestDto);
        Task DeleteAsync(int id);
        Task<IEnumerable<CollectionResDTO>> GetAllAsync();
        Task<CollectionResDTO> GetByIdAsync(int id);
    }
}
