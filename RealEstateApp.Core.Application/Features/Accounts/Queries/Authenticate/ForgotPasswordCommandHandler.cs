using MediatR;
using RealEstateApp.Core.Application.DTOs.Account;
using RealEstateApp.Core.Application.Features.Accounts.Commands.ForgetPasswordUser;
using RealEstateApp.Core.Application.Interfaces.Services;

namespace RealEstateApp.Core.Application.Features.Accounts.Queries.Authenticate
{
    public class ForgotPasswordCommandHandler : IRequestHandler<ForgotPasswordCommand, ForgotPasswordResponse>
    {
        private readonly IAccountService _accountService;

        public ForgotPasswordCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<ForgotPasswordResponse> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
            var forgotPasswordRequest = new ForgotPasswordRequest
            {
                Email = request.Email,
                Origin = request.Origin,
            };

            return await _accountService.ForgotPasswordAsync(forgotPasswordRequest, request.Origin);
        }
    }
}
