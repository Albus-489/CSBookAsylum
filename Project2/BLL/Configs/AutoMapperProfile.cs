using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Text;
using System.Threading.Tasks;
using Project2.BLL.DTO.Req;
using Project2.BLL.DTO.Res;
using Project2.DAL.Entities;

namespace Project2.BLL.Configs
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateUserMaps();
        }

        private void CreateUserMaps()
        {
            CreateMap<UserSignUpReq, Users>();
            CreateMap<Users, UserResDTO>();

        }
    }
}
