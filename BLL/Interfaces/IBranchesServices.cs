using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Interfaces
{
    public interface IBranchesServices
    {
        Task<IEnumerable<BranchesResDTO>> GetAllBranches();
        Task AddAsync(BranchesReqDTO branch);
        Task UpdateAsync(BranchesReqDTO branch);
        Task DeleteAsync(long id);
    }
}
