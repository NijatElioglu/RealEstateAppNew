using RealEstateApp.Core.Application.DTOs.Email;
using RealEstateApp.Core.Domain.Settings;

namespace RealEstateApp.Core.Application.Interfaces.Services
{
    public interface IEmailService
    {
        public MailSettings _mailSettings { get; }
        Task SendEmailAsync(EmailRequest request);
    }
}
