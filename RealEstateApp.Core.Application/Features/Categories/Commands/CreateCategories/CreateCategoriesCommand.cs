using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Core.Application.Features.Categories.Commands.CreateCategories
{
    public class CreateCategoriesCommand : IRequest<int>
    {
        [Required(ErrorMessage = "This field is required.")]
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