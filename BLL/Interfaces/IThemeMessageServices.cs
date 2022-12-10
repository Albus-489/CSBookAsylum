using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Interfaces
{
    public interface IThemeMessageServices
    {
        Task<IEnumerable<ThemeMessageResDTO>> GetAllThemeMessages();
        Task AddAsync(ThemeMessageReqDTO themeMeassage);
        Task UpdateAsync(ThemeMessageReqDTO themeMeassage);
        Task DeleteAsync(long id);
    }
}
