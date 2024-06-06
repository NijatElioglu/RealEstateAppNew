using AutoMapper;
using MediatR;
using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;


namespace RealEstateApp.Core.Application.Features.Category.Commands.DeleteCategory
{
    public class DeleteCategoriesByİd : IRequest<int>
    {
        public int Id { get; set; }
    }


    public class DeleteCategoriesByIdCommandHandler : IRequestHandler<DeleteCategoriesByİd, int>
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;
        public DeleteCategoriesByIdCommandHandler(ICategoriesRepository categoriesRepository, IMapper mapper)
        {
            _categoriesRepository = categoriesRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(DeleteCategoriesByİd request, CancellationToken cancellationToken)
        {
            var Categories = await _categoriesRepository.GetByIdAsync(request.Id);
            if (Categories == null) throw new Exception("The property type was not found");

            await _categoriesRepository.DeleteAsync(Categories);


            return Categories.Id;
        }
    }
}
