using AutoMapper;
using BLLP4.DTO.Req;
using BLLP4.DTO.Res;
using DALP4.Entities;

namespace BLLP4.Configs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateUserRegisterMaps();

        }

        private void CreateUserRegisterMaps()
        {
            CreateMap<RegisterRequestDTO, AppUser>();
        }

        private void CreateUserLoginMaps()
        {
            CreateMap<LoginRequestDTO, AppUser>();
            CreateMap<AppUser, UserResponseDTO>();
        }
    }
}
