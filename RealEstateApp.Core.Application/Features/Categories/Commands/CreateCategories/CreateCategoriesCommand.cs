using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Features.TypeOfProperties.Commands.CreateTypeOfProperties;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Core.Application.Features.TypeOfSales.Commands.CreateTypeOfSales;

namespace RealEstateApp.Core.Application.Features.Categories.Commands.CreateCategories
{
    public class CreateCategoriesCommand:IRequest<int>
    {
        [SwaggerParameter(Description = "El nombre del tipo de propiedad")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Name { get; set; }

        
    }
    public class CreateTypeOfPropertiesCommandHandler : IRequestHandler<CreateCategoriesCommand, int>
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;
        public CreateTypeOfPropertiesCommandHandler(ICategoriesRepository categoriesRepository, IMapper mapper)
        {
            _categoriesRepository = categoriesRepository;  
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateCategoriesCommand command, CancellationToken cancellationToken)
        {
            var improvements = _mapper.Map<RealEstateApp.Core.Domain.Entities.Categories>(command);
            improvements = await _categoriesRepository.AddAsync(improvements);
            return improvements.Id;
        }
    }
}
