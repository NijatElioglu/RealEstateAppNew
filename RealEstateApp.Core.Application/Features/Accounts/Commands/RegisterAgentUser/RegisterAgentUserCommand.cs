using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.DTOs.Account;
using RealEstateApp.Core.Application.Enums;
using RealEstateApp.Core.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RealEstateApp.Core.Application.Features.Accounts.Commands.RegisterAgentUser
{
    public class RegisterAgentUserCommand:IRequest<RegisterResponse>
    {
        [Required(ErrorMessage = "This field is required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Confirmation is required")]
        [Compare(nameof(Password), ErrorMessage = "Password Mismatch")]
        public string? ConfirmPassword { get; set; }
        public string? Phone { get; set; }
        public string? ImagePath { get; set; }
        public bool EmailConfirmed { get; set; }
    }


    public class RegisterAgentUserCommandHandler : IRequestHandler<RegisterAgentUserCommand, RegisterResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;
        public RegisterAgentUserCommandHandler(IMapper mapper,IAccountService accountService)
        {
            _mapper = mapper;
            _accountService = accountService;
        }
        public async Task<RegisterResponse> Handle(RegisterAgentUserCommand command, CancellationToken cancellationToken)
        {
            command.EmailConfirmed = true;
            var request = _mapper.Map<RegisterRequest>(command);
            return await _accountService.RegisterUserAsync(request, "", Roles.Agent);
        }
    }

}
