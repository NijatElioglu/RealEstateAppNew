using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Core.Application.ViewModels.Categories
{
    public class SaveCategoriesViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
