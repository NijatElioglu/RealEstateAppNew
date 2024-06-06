using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using RealEstateApp.Core.Application.Interfaces.Repositories;

namespace RealEstateApp.Core.Application.Features.Properties.Commands.UpdateProperties
{
    public class UpdatePropertiesCommand : IRequest<UpdatePropertiesResponse>
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public decimal? Price { get; set; }
        public int? LandSize { get; set; }
        public int? NumberOfRooms { get; set; }
        public int? NumberOfBathrooms { get; set; }
        public string? Description { get; set; }
        public string? ImagePathOne { get; set; }
        public IFormFile? ImageFileOne { get; set; }
        public string? ImagePathTwo { get; set; }
        public IFormFile? ImageFileTwo { get; set; }
        public string? ImagePathThree { get; set; }
        public IFormFile? ImageFileThree { get; set; }
        public string? ImagePathFour { get; set; }
        public IFormFile? ImageFileFour { get; set; }
        public int? TypeOfPropertyId { get; set; }
        public int? TypeOfSaleId { get; set; }
        public List<int>? ImprovementsId { get; set; }
    }

    public class UpdatePropertiesCommandHandler : IRequestHandler<UpdatePropertiesCommand, UpdatePropertiesResponse>
    {

        private readonly IPropertiesRepository _propertiesRepository;
        private readonly IMapper _mapper;
        public UpdatePropertiesCommandHandler(IPropertiesRepository propertiesRepository, IMapper mapper)
        {
            _propertiesRepository = propertiesRepository;
            _mapper = mapper;
        }


        public async Task<UpdatePropertiesResponse> Handle(UpdatePropertiesCommand request, CancellationToken cancellationToken)
        {
            var Properties = await _propertiesRepository.GetByIdAsync(request.Id);
            if (Properties == null) throw new Exception("El tipo de propiedad no ha sido encontrada.");

            await _propertiesRepository.UpdateAsync(Properties, Properties.Id);
            var PropertiesResponse = _mapper.Map<UpdatePropertiesResponse>(Properties);
            return PropertiesResponse;
        }
    }
}
