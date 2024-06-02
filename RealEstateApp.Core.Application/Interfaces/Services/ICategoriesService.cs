using RealEstateApp.Core.Application.ViewModels.Categories;
using RealEstateApp.Core.Domain.Entities;

namespace RealEstateApp.Core.Application.Interfaces.Services
{
    public interface ICategoriesService : IGenericService<SaveCategoriesViewModel, CategoriesViewModel, Categories>
    {
    }
}
