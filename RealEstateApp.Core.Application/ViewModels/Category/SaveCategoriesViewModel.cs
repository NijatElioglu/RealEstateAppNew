using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Core.Application.ViewModels.Categories
{
    public class SaveCategoriesViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
