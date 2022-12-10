using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Interfaces
{
    public interface IThemesServices
    {
        Task<IEnumerable<ThemesResDTO>> GetAllThemes();
        Task AddAsync(ThemesReqDTO theme);
        Task UpdateAsync(ThemesReqDTO theme);
        Task DeleteAsync(long id);
    }
}
