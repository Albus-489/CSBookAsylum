using BLL_Project2.DTO;
using BLL_Project2.DTO.Requests;

namespace WEBAPI_Project2.Helpers
{
    public interface IIdentity
    {
        Task<AuthenticationDTO> SignInAsync(UserSignInReq request);

        Task<AuthenticationDTO> SignUpAsync(UserSignUpReq request);
    }
}
