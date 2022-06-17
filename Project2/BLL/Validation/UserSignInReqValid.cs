using FluentValidation;
using Project2.BLL.DTO.Req;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.BLL.Validation
{
    public class UserSignInReqValid : AbstractValidator<UserSignInReq>
    {
        public UserSignInReqValid()
        {
            RuleFor(request => request.UserName)
                .NotEmpty()
                .WithMessage("UserName can't be empty.");

            RuleFor(request => request.Password)
                .NotEmpty()
                .WithMessage("Password can't be empty.");
        }
    }
}
