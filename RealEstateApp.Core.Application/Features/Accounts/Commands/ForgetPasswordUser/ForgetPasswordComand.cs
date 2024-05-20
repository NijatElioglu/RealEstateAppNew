using MediatR;
using RealEstateApp.Core.Application.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Accounts.Commands.ForgetPasswordUser
{

    public class ForgotPasswordCommand : IRequest<ForgotPasswordResponse>
    {
        public string Email { get; set; }
        public string Origin { get; set; }

        public ForgotPasswordCommand() { }

        public ForgotPasswordCommand(string email, string origin)
        {
            Email = email;
            Origin = origin;
        }
    }
}
