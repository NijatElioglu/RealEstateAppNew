using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.DTOs.Account;
using RealEstateApp.Core.Application.Enums;
using RealEstateApp.Core.Application.Interfaces.Services;
using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Core.Application.Features.Accounts.Commands.RegisterDeveloperUser
{
    public class RegisterSellerUserCommand : IRequest<RegisterResponse>
    {
        [Required(ErrorMessage = "This field is required.")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Compare(nameof(Password), ErrorMessage = "Mismatch.")]
        public string? ConfirmPassword { get; set; }
        public string? Phone { get; set; }
        public string? ImagePath { get; set; }
        public bool EmailConfirmed { get; set; }
    }
    public class RegisterSellerUserCommandHandler : IRequestHandler<RegisterSellerUserCommand, RegisterResponse>
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public RegisterSellerUserCommandHandler(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }
        
        public async Task<RegisterResponse> Handle(RegisterSellerUserCommand command, CancellationToken cancellationToken)
        {
            command.EmailConfirmed = true;
            var request = _mapper.Map<RegisterRequest>(command);
            return await _accountService.RegisterUserAsync(request, "", Roles.Seller);
        }
    }
}
