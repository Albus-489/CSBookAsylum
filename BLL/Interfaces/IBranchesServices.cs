using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Interfaces
{
    public interface IBranchesServices<T>
    {
        Task<IEnumerable<BranchesResDTO>> GetAllByOrderIdAsync(long id);
        Task<long> AddAsync(BranchesReqDTO post);
        Task UpdateAsync(BranchesReqDTO post);
        Task DeleteAsync(long id);
    }
}
