using BLLP4.DTO.Req;
using BLLP4.DTO.Res;
using DALP4.Entities;

namespace BLLP4.Interfaces
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterRequestDTO dto);
        Task<UserResponseDTO> GetTokenAsync(LoginRequestDTO model);
        Task<string> AddRoleAsync(AddRoleRequestDTO model);
        Task<UserResponseDTO> RefreshTokenAsync(string token);
        AppUser GetById(string id);

        bool RevokeToken(string token);
    }
}
