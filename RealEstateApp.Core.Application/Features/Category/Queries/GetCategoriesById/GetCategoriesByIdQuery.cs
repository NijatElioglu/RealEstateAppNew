using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Application.ViewModels.Categories;
using RealEstateApp.Core.Application.ViewModels.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RealEstateApp.Core.Application.Features.Category.Queries.GetCategoriesById
{
    public class GetCategoriesByIdQuery:IRequest<CategoriesViewModel>
    {
        public int Id { get; set; }
    }

    public class GetCategoriesByIdHandler : IRequestHandler<GetCategoriesByIdQuery, CategoriesViewModel>
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;

        public GetCategoriesByIdHandler(ICategoriesRepository categoriesRepository, IMapper mapper)
        {
            _categoriesRepository = categoriesRepository;
            _mapper = mapper;
        }
        public async Task<CategoriesViewModel> Handle(GetCategoriesByIdQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoriesRepository.GetAllAsync();
            var category = categories.FirstOrDefault(x => x.Id == request.Id);
            if (category is null) throw new Exception("No existe la propiedad.");
           
            return _mapper.Map<CategoriesViewModel>(category);
        }
    }
}
