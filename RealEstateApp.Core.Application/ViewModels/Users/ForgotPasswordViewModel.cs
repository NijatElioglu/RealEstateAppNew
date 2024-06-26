﻿using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Core.Application.ViewModels.Users
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "You must type the Email")]
        [DataType(DataType.Text)]
        public string? Email { get; set; }

        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
