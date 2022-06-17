using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Interfaces
{
    public interface IUsersServices
    {
        Task<IEnumerable<UsersResDTO>> GetAllAsync();
        Task<long> AddAsync(UsersReqDTO user);
        Task UpdateAsync(UsersReqDTO user);
        Task DeleteAsync(long id);
    }
}
