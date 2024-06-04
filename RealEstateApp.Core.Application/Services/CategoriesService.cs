using AutoMapper;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Application.Interfaces.Services;
using RealEstateApp.Core.Application.ViewModels.Categories;
using RealEstateApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Services
{
    public class CategoriesService : GenericService<SaveCategoriesViewModel, CategoriesViewModel, Categories>, ICategoriesService
    {
        public CategoriesService(IGenericRepository<Categories> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
