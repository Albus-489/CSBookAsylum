﻿using AutoMapper;
using BLL_Project2.DTO;
using BLL_Project2.DTO.Requests;
using Project2.DAL.Entities;
using Project2.DAL.Interfaces;
using Project2.WEBAPI_PR2.JWTManager;

namespace WEBAPI_Project2.Helpers
{
    public class Identity:IIdentity
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IConfiguration _configuration;

        private readonly IMapper _mapper;

        public Identity(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<AuthenticationDTO> SignInAsync(UserSignInReq request)
        {
            var authenticationDTO = new AuthenticationDTO();
            var user = await _unitOfWork.UserManager.FindByNameAsync(request.UserName);

            if (user == null)
            {
                authenticationDTO.IsAuthenticated = false;
                authenticationDTO.Message = $"No Accounts Registered with {request.UserName}.";
                return authenticationDTO;
            }

            if (await _unitOfWork.UserManager.CheckPasswordAsync(user, request.Password))
            {
                var token = _configuration.GenerateJwtToken(user);
                authenticationDTO.IsAuthenticated = true;
                authenticationDTO.Token = token;
                authenticationDTO.Email = user.Email;
                authenticationDTO.UserName = user.UserName;
                var rolesList = await _unitOfWork.UserManager.GetRolesAsync(user).ConfigureAwait(false);
                authenticationDTO.Roles = rolesList.ToList();


                return authenticationDTO;
            }

            authenticationDTO.IsAuthenticated = false;
            authenticationDTO.Message = $"Incorrect Credentials for user {user.UserName}.";
            return authenticationDTO;

        }

        public async Task<AuthenticationDTO> SignUpAsync(UserSignUpReq request)
        {
            var user = _mapper.Map<UserSignUpReq, Users>(request);
            var signUpResult = await _unitOfWork.UserManager.CreateAsync(user, request.Password);

            if (!signUpResult.Succeeded)
            {
                string errors = string.Join("\n",
                    signUpResult.Errors.Select(error => error.Description));

                throw new ArgumentException(errors);
            }

            await _unitOfWork.SaveChangesAsync();

            var signIn = new UserSignInReq();
            signIn.UserName = request.UserName;
            signIn.Password = request.Password;

            return await SignInAsync(signIn);
        }

    }
}
