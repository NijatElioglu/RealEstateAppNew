using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Features.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<UpdateCategoryResponse>
    {
        public int Id { get; set; }
        [SwaggerParameter(Description = "El nombre del tipo de propiedad")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Name { get; set; }
    }

    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdateCategoryResponse>
    {
        private readonly ICategoriesRepository _categoryRepository;
        private readonly IMapper _mapper;
        public UpdateCategoryCommandHandler(ICategoriesRepository categoriesRepository, IMapper mapper)
        {
            _categoryRepository = categoriesRepository;
            _mapper = mapper;
        }
        public async Task<UpdateCategoryResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);
            if (category == null) throw new Exception("El tipo de propiedad no ha sido encontrada.");

            await _categoryRepository.UpdateAsync(category, category.Id);
            var CategoryResponse = _mapper.Map<UpdateCategoryResponse>(category);
            return CategoryResponse;
        }
    }
}
