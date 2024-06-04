using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Razor.TagHelpers;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Category.CreateCategory
{
    public class CreateCategoryCommand:IRequest<int>
    {
        [SwaggerParameter(Description = "El nombre del tipo de propiedad")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Name { get; set; }
     
    }

    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoriesRepository categoriesRepository,IMapper mapper)
        {
            _categoriesRepository = categoriesRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Categories>(request);
            category =await _categoriesRepository.AddAsync(category);
            return category.Id;
        }
    }
}
