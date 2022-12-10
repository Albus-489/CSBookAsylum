using AutoMapper;
using Project1.DAL.Models;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;

namespace Project1.BLL.Configs
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateBrancheMaps();
            CreateThemeMaps();
            CreateThemeMessageMaps();
        }

        private void CreateBrancheMaps()
        {
            CreateMap<Branches, BranchesResDTO>();
            CreateMap<BranchesReqDTO, Branches>();
        }

        private void CreateThemeMaps()
        {
            CreateMap<Themes, ThemesResDTO>();
            CreateMap<ThemesReqDTO, Themes>();
        }

        private void CreateThemeMessageMaps()
        {
            CreateMap<ThemeMessage, ThemeMessageResDTO>();
            CreateMap<ThemeMessageReqDTO, ThemeMessage>();
        }
    }
}
