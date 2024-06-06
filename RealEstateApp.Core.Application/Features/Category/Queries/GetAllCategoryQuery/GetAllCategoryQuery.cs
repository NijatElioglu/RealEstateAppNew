using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Application.ViewModels.Announement;
using RealEstateApp.Core.Application.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Category.Queries.GetAllCategoryQuery
{
    public class GetAllCategoryQuery: IRequest<IEnumerable<CategoriesViewModel>>
    {
        public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, IEnumerable<CategoriesViewModel>>
        {
            private readonly ICategoriesRepository _categoryRepository;
            private readonly IMapper _mapper;


            public GetAllCategoryQueryHandler(ICategoriesRepository categoryRepository, IMapper mapper)
            {
                _categoryRepository = categoryRepository;
                _mapper = mapper;   
            }

            public async Task<IEnumerable<CategoriesViewModel>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
            {
                var GetAllCategory = await GetAllViewModel();
                return GetAllCategory;
            }
            private async Task<List<CategoriesViewModel>> GetAllViewModel()
            {
                var Category = await _categoryRepository.GetAllAsync();
                if (Category.Count() == 0) throw new Exception("No Exits");
                var result = _mapper.Map<List<CategoriesViewModel>>(Category);
                return result;
            }
        }

    }
}
