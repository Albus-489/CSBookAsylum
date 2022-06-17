using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Interfaces
{
    public interface IThemeMessageServices<T>
    {
        Task<IEnumerable<ThemeMessageResDTO>> GetAllByOrderIdAsync(long id);
        Task<long> AddAsync(ThemeMessageReqDTO post);
        Task UpdateAsync(ThemeMessageReqDTO post);
        Task DeleteAsync(long id);
    }
}
