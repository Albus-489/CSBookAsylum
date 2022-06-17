using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Interfaces
{
    public interface IThemesServices<T>
    {
        Task<IEnumerable<ThemesResDTO>> GetAllByOrderIdAsync(long id);
        Task<long> AddAsync(ThemesReqDTO post);
        Task UpdateAsync(ThemesReqDTO post);
        Task DeleteAsync(long id);
    }
}
