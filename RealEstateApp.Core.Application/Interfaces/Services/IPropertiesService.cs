using RealEstateApp.Core.Application.ViewModels.Properties;
using RealEstateApp.Core.Domain.Entities;

namespace RealEstateApp.Core.Application.Interfaces.Services
{
    public interface IPropertiesService : IGenericService<SavePropertiesViewModel, PropertiesViewModel, Properties>
    {
        Task<PropertiesViewModel> GetByCode(string code);
        Task<PropertiesViewModel> GetByIdWithData(int id);
        Task<List<PropertiesViewModel>> GetAllWithData();
        Task<SavePropertiesViewModel> CustomAdd(SavePropertiesViewModel savePropertiesViewModel);
        Task<SaveAgentProfileViewModel> UpdateAgentProfile(SaveAgentProfileViewModel agentProfileViewModel);
        Task<SaveAgentProfileViewModel> GetAgentUserByUserNameAsync(string userName);
        Task<List<PropertiesViewModel>> GetAll();

        Task<List<PropertiesViewModel>> GetAllWithInclude();
        Task<SavePropertiesViewModel> GetByIdWithInclude(int id);
        Task<List<PropertiesViewModel>> GetAllByAgentIdWithInclude(string agentId);

        Task<PropertyDetailsViewModel> GetPropertyDetailsAsync(int propertyId);
        Task<List<PropertiesViewModel>> GetAllWithFilters(FilterPropertiesViewModel filterPropertiesViewModel);
    }
}
