using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.DTOs.Account;
using RealEstateApp.Core.Application.Interfaces.Services;
using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Core.Application.Features.Accounts.Queries.Authenticate
{
    public class AuthenticateUserQuery : IRequest<AuthenticationResponse>
    {
        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }
    }

    public class AuthenticateUserQueryHandler : IRequestHandler<AuthenticateUserQuery, AuthenticationResponse>
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AuthenticateUserQueryHandler(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<AuthenticationResponse> Handle(AuthenticateUserQuery query, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<AuthenticationRequest>(query);
            var response = await _accountService.AuthenticateAsync(data);

            if (response.HasError == false)
            {
                foreach (var rol in response.Roles)
                {
                    if (rol == "Agent" || rol == "Seller") throw new Exception("Permission denied.");
                }
            }
            return response;
        }
    }
}
