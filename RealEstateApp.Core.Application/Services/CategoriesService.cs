using AutoMapper;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Application.Interfaces.Services;
using RealEstateApp.Core.Application.ViewModels.Categories;
using RealEstateApp.Core.Domain.Entities;

namespace RealEstateApp.Core.Application.Services
{
    public class CategoriesService : GenericService<SaveCategoriesViewModel, CategoriesViewModel, Categories>, ICategoriesService
    {
        private readonly IGenericRepository<Categories> _repository;
        private readonly IMapper _mapper;

        public CategoriesService(IGenericRepository<Categories> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
