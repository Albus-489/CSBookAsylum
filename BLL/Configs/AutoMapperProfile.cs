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
            CreateUserMaps();
            CreateBrancheMaps();
            CreateThemeMaps();
            CreateThemeMessageMaps();
        }

        private void CreateUserMaps()
        {
            CreateMap<AspNetUsers, UsersResDTO>();
            CreateMap<UsersResDTO, AspNetUsers>();
        }

        private void CreateBrancheMaps()
        {
            CreateMap<Branches, BranchesResDTO>();
        }

        private void CreateThemeMaps()
        {
            CreateMap<Themes, ThemesResDTO>();
        }

        private void CreateThemeMessageMaps()
        {
            CreateMap<ThemeMessage, ThemeMessageResDTO>();
        }
    }
}
